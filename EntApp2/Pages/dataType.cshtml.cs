using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp2.Pages
{
    public class dataTypeModel : PageModel
    {
        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime Date { get; set;  }

        [BindProperty]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [BindProperty]
        [DataType(DataType.Duration)]
        public DateTime Duration { get; set; }

        [BindProperty]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [BindProperty]
        [DataType(DataType.Currency)]
        public int Currency { get; set; }

        [BindProperty]
        [DataType(DataType.Text)]
        public string Text { get; set; }

        [BindProperty]
        [DataType(DataType.Html)]
        public string Html { get; set; }

        [BindProperty]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [BindProperty]
        [DataType(DataType.MultilineText)]
        public string MultilineText { get; set; }

        [BindProperty]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public void OnGet()
        {

        }
    }
}