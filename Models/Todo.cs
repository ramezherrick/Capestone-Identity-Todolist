using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Capestone_ToDoList.Models
{
    public partial class Todo
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength =1, ErrorMessage ="Invalid Entry")]
        public string Item { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        public bool Completed { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
