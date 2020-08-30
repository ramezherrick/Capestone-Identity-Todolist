using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Capestone_ToDoList.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Capestone_ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoIdentityDbContext _context;


        public HomeController(TodoIdentityDbContext context)
        {
            _context = context;
            
        }

        //Using Youtube video https://www.youtube.com/watch?v=xG56lRe6ptc
        //create a class clsCommon that return current user
        //if CEO is loggein in, the view will direct to the CEO VIEW where he could see how many users he has and their Ids
        
        //login:iamceo@CEO.com
        //password:Hello!12345

        public async Task<IActionResult> IndexAsync()
        {
            string idOfCurrentUser = Classes.ExtensionMethods.getUserId(this.User);

            var user = await _context.AspNetUsers.SingleOrDefaultAsync(m => m.Id == idOfCurrentUser);

            if (idOfCurrentUser == "9d538fe8-540f-4d6e-8d2b-aba4f60a4d8f")
            {
                return View("ceo");
            }
            return View();
        }

        //ADD
        [HttpGet]
        public IActionResult AddTask()
        {
            return View(new Todo());
        }
        [HttpPost]
        public IActionResult AddTask(Todo todo)
        {
            todo.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if(ModelState.IsValid)
            {
                _context.Todo.Add(todo);
                _context.SaveChanges();
            }
            return View(todo);
        }




        //Read
        [Authorize]
        public IActionResult DisplayTask()
        {
            //primary key of user logged in
            string id = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //list associated with logged in user
            var todoList = _context.Todo.Where(x => x.UserId == id).ToList();
            return View(todoList);
        }

        //Delete
        public IActionResult DeleteTask(int id)
        {
            var finditem = _context.Todo.Find(id);

            if (finditem != null)
            {
                _context.Todo.Remove(finditem);
                _context.SaveChanges();
            }
            return RedirectToAction("DisplayTask");
        }

        //Mark Complete
        public IActionResult MarkComplete(int id, Todo updatedtodo)
        {
            //find the Todo item that you want to change completion status
            Todo itemToMarkComplete = _context.Todo.Find(id);

            //if somehow a null item was selected. Possibly deleted on a different browser
            if (itemToMarkComplete == null)
            {
                return RedirectToAction("DisplayTask");
            }
            else
            {
                Todo dbTodo = _context.Todo.Find(updatedtodo.Id);
                dbTodo.Completed = !dbTodo.Completed;
                _context.Entry(dbTodo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(dbTodo);
                _context.SaveChanges();

                return RedirectToAction("DisplayTask");
            }
        }

        //search by title name
        [HttpGet]
        public IActionResult SearchToDoItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchToDoItem(string name)
        {
            var searchedItem = _context.Todo.Where(s => s.Item.Contains(name)).ToList();

            return View(searchedItem);
        }

        //sort/filter by date
        [HttpGet]
        public IActionResult SortByDueDate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SortByDueDate(DateTime date)
        {

            var searchedItem = _context.Todo.Where(s => s.DueDate < date).ToList();

            return View(searchedItem);
        }
        //sort/filter by date
        [HttpGet]
        public IActionResult SortByCompletionStatus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SortByCompletionStatus(bool completionStatus)
        {
            var searchedItem = _context.Todo.Where(s => s.Completed == completionStatus).ToList();
            return View(searchedItem);
        }

        //ADMIN
        //Display users
        public IActionResult DisplayUsers()
        {
            var userList = _context.AspNetUsers.ToList();
            return View(userList);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}

