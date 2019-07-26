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
    public class IndexModel : PageModel
    {
        private readonly SummerInternRegistration.Models.SummerInternRegistrationContext _context;

        public IndexModel(SummerInternRegistration.Models.SummerInternRegistrationContext context)
        {
            _context = context;
        }

        public IList<Intern> Intern { get;set; }

        public async Task OnGetAsync()
        {
            Intern = await _context.Intern.ToListAsync();
        }
    }
}
