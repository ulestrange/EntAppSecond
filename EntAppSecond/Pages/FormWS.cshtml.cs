using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class FormWSModel : PageModel
    {

        [BindProperty]
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }

        [BindProperty]

        public string ColourChosen { get; set; } 

        public string[] ColourChoices { get; set; } = { "Red", "Yellow", "Black" };

        [BindProperty]
        public bool HasConsented { get; set; }

        public int Quantity { get; set; }

   
        public void OnGet()
        {

        }
    }
}