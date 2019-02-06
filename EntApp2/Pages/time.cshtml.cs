using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EntApp2.Pages
{
    public class timeModel : PageModel
    {
        public string[] Message= new string[7];
        public string Message1 { get; set; }

        

        public string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        [BindProperty]
        public bool[] DaysSelected { get; set; } = { false, false, false, false, false, false, false };

        [BindProperty]
        public string[] MonthSelected { get; set; } = { };

        public List<SelectListItem> Month { get; } =
            new List<SelectListItem>
            {
                new SelectListItem {Value = "January", Text="January"},
                new SelectListItem {Value = "February", Text="February"},
                new SelectListItem {Value = "March", Text="March"},
                new SelectListItem {Value = "April", Text="April"},
                new SelectListItem {Value = "May", Text="May"},
                new SelectListItem {Value = "June", Text="June"},
                new SelectListItem {Value = "July", Text="July"},
                new SelectListItem {Value = "August", Text="August"},
                new SelectListItem {Value = "September", Text="September"},
                new SelectListItem {Value = "October", Text="October"},
                new SelectListItem {Value = "November", Text="November"},
                new SelectListItem {Value = "December", Text="December"}
            };
        
        public void OnPost()
        {
            if(MonthSelected.Length == 0)
            {
                Message1 = "No month selected"; 
            }
            else
            {
                Message1 = $"<ol>";
                foreach (string month in MonthSelected)
                {
                    Message1 += $"<li>{month}</li>";
                }
                Message1 += $"</ol>";
            }
        }

        public void OnGet()
        {

        }
    }
}