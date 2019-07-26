using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SummerInternRegistration.Models;

namespace SummerInternRegistrations.Pages.Interns
{
    public class EditModel : PageModel
    {
        private readonly SummerInternRegistration.Models.SummerInternRegistrationContext _context;

        public EditModel(SummerInternRegistration.Models.SummerInternRegistrationContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Intern).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InternExists(Intern.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InternExists(int id)
        {
            return _context.Intern.Any(e => e.ID == id);
        }
    }
}
