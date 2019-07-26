using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SummerInternRegistration.Models;

namespace SummerInternRegistrations.Pages.Interns
{
    public class DeleteModel : PageModel
    {
        private readonly SummerInternRegistration.Models.SummerInternRegistrationContext _context;

        public DeleteModel(SummerInternRegistration.Models.SummerInternRegistrationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Intern Intern { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Intern = await _context.Intern.FirstOrDefaultAsync(m => m.ID == id);

            if (Intern == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Intern = await _context.Intern.FindAsync(id);

            if (Intern != null)
            {
                _context.Intern.Remove(Intern);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
