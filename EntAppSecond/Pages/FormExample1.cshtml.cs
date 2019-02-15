using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages
{
    public class FormExample1Model : PageModel
    {
        [BindProperty]
        [Display (Name = "Email Address")]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]

        public bool HasConsented { get; set; }
        public void OnGet()
        {
            var hello = HasConsented;
        }
    }
}