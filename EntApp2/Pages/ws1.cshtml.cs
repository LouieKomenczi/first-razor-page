using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp2.Pages
{
    public class ws1Model : PageModel
    {
        public string[] MyTestArray { get; set; } 
        
        public string Message { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var name = Request.Form["name"];
            Message = "Hello " + name;

        }
    }
}