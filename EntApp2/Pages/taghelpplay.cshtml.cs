using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace EntApp2.Pages
{
    public class taghelpplayModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int? Number2 { get; set; }

        [BindProperty]
        public Double Number3 { get; set; }

        [BindProperty]
        public Double? Number4 { get; set; }

        [BindProperty]
        public Decimal Number5 { get; set; }

        [BindProperty]
        public Decimal? Number6 { get; set; }

        [BindProperty]
        public float Number7 { get; set; }

        [BindProperty]
        public float? Number8 { get; set; }

        [BindProperty]
        public string String1 { get; set; }
        
        [BindProperty]
        public DateTime Datetime1 { get; set; }

        [BindProperty]
        public bool IsContactAllowed { get; set; }
        
        [BindProperty]
        public string Season { get; set; }

        public string Message { get; set; }

        

        public void OnPost()
        {
                  
                
        }
    }
}