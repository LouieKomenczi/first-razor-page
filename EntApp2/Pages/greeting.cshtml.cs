using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp2.Pages
{
    public class greetingModel : PageModel
    {
        public string Message { get; set; } = "this Hello is set in the model! ";


        public void OnGet()
        {
            if(DateTime.Now.Hour >= 12)
            {
                Message += "Good Afternoon";
            }
            else
            {
                Message += "Good Morning";
            }

            Message += " - this is the month of " + DateTime.Now.ToString("MMMM");
        }
    }
}