using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SummerInternRegistration.Models;

namespace SummerInternRegistrations.Pages.Interns
{
    public class CreateModel : PageModel
    {
        private readonly SummerInternRegistration.Models.SummerInternRegistrationContext _context;

        public CreateModel(SummerInternRegistration.Models.SummerInternRegistrationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Intern Intern { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Intern.Add(Intern);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}