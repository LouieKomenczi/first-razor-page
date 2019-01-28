using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp2.Pages
{
    public class ws1BModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var n1 = Convert.ToInt32(Request.Form["n1"]);
            var n2 = Convert.ToInt32(Request.Form["n2"]);
            var op = Request.Form["operation"];
            if (op == "add")
            {
                Message = Convert.ToString(n1) + " + " + Convert.ToString(n2) + " = " + Convert.ToString(n1 + n2);
            }
            if (op == "sub")
            {
                Message = Convert.ToString(n1) + " - " + Convert.ToString(n2) + " = " + Convert.ToString(n1 - n2);
            }
            if (op == "mul")
            {
                Message = Convert.ToString(n1) + " * " + Convert.ToString(n2) + " = " + Convert.ToString(n1 * n2);
            }
            if (op == "div")
            {
                if(n2 == 0)
                {
                    Message = "Divison by 0 not possibe ";
                }
                else
                {
                    Message = Convert.ToString(n1) + " / " + Convert.ToString(n2) + " = " + Convert.ToString(n1 / n2);
                }           
                
            }
        }
    }
}