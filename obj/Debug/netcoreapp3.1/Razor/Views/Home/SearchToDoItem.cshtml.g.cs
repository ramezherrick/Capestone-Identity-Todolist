#pragma checksum "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6be5895f7336184b90f80db707e5d00f944a9523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchToDoItem), @"mvc.1.0.view", @"/Views/Home/SearchToDoItem.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\_ViewImports.cshtml"
using Capestone_ToDoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\_ViewImports.cshtml"
using Capestone_ToDoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6be5895f7336184b90f80db707e5d00f944a9523", @"/Views/Home/SearchToDoItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c57d683d1f087b2e8a44cfdcd5dcdb0d6e9509d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchToDoItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Todo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Home/SearchToDoItem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    body {\r\n        background-color: black;\r\n    }\r\n\r\n</style>\r\n\r\n\r\n<h1 style=\"color:white\">Search items by title</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6be5895f7336184b90f80db707e5d00f944a95234058", async() => {
                WriteLiteral("\r\n    <label for=\"name\" style=\"color:white\">Title</label>\r\n    <input type=\"text\" name=\"name\" />\r\n    <input type=\"submit\" value=\"find item\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n\r\n<table class=\"table\" style=\"color:white\">\r\n    <tr class=\"d-table-row\">\r\n        <th>Item</th>\r\n        <th>Due Date</th>\r\n        <th>Completion Status</th>\r\n    </tr>\r\n");
#nullable restore
#line 24 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"
     if (Model != null)
    {
        foreach (Todo todo in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"d-table-row\">\r\n                <th>");
#nullable restore
#line 29 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"
               Write(todo.Item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 30 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"
                 if (todo.DueDate < DateTime.Now && todo.Completed == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"color:red\">");
#nullable restore
#line 32 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"
                                     Write(todo.DueDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"color:red\">");
#nullable restore
#line 33 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"
                                     Write(todo.Completed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"

                }

                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 39 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"
                   Write(todo.DueDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"
                   Write(todo.Completed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\herri\source\repos\Capestone-ToDoList\Views\Home\SearchToDoItem.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"../Home/Index\" class=\"btn btn-primary\">Home</a>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Todo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
