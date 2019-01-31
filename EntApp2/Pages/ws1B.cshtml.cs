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
        [BindProperty]
        public int N1 { get; set; }
        [BindProperty]
        public int N2 { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            var N1 = Convert.ToInt32(Request.Form["N1"]);
            var N2 = Convert.ToInt32(Request.Form["N2"]);
            var op = Request.Form["operation"];
            if (op == "add")
            {
                Message = Convert.ToString(N1) + " + " + Convert.ToString(N2) + " = " + Convert.ToString(N1 + N2);
            }
            if (op == "sub")
            {
                Message = Convert.ToString(N1) + " - " + Convert.ToString(N2) + " = " + Convert.ToString(N1 - N2);
            }
            if (op == "mul")
            {
                Message = Convert.ToString(N1) + " * " + Convert.ToString(N2) + " = " + Convert.ToString(N1 * N2);
            }
            if (op == "div")
            {
                if(N2 == 0)
                {
                    Message = "Divison by 0 not possibe ";
                }
                else
                {
                    Message = Convert.ToString(N1) + " / " + Convert.ToString(N2) + " = " + Convert.ToString(N1 / N2);
                }           
                
            }
        }
    }
}