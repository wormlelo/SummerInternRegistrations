using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SummerInternRegistration.Models
{
    public class SummerInternRegistrationContext : DbContext
    {
        public SummerInternRegistrationContext (DbContextOptions<SummerInternRegistrationContext> options)
            : base(options)
        {
        }

        public DbSet<SummerInternRegistration.Models.Intern> Intern { get; set; }
    }
}
