//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Linq;

//namespace SummerInternRegistrations.Models
//{
//    public class SeedData
//    {
//        public static void Initialize(IServiceProvider serviceProvider)
//        {
//            using (var context = new SummerInternRegistrationContext(
//                serviceProvider.GetRequiredService<
//                    DbContextOptions<SummerInternRegistrationContext>>()))
//            {
//                // Look for any Interns.
//                if (context.Intern.Any())
//                {
//                    return;   // DB has been seeded
//                }

//                context.Intern.AddRange(
//                    new Intern
//                    {
//                        Title = "When Harry Met Sally",
//                        ReleaseDate = DateTime.Parse("1989-2-12"),
//                        Genre = "Romantic Comedy",
//                        Price = 7.99M
//                    },

//                    new Intern
//                    {
//                        Title = "Ghostbusters ",
//                        ReleaseDate = DateTime.Parse("1984-3-13"),
//                        Genre = "Comedy",
//                        Price = 8.99M
//                    },

//                    new Intern
//                    {
//                        Title = "Ghostbusters 2",
//                        ReleaseDate = DateTime.Parse("1986-2-23"),
//                        Genre = "Comedy",
//                        Price = 9.99M
//                    },

//                    new Intern
//                    {
//                        Title = "Rio Bravo",
//                        ReleaseDate = DateTime.Parse("1959-4-15"),
//                        Genre = "Western",
//                        Price = 3.99M
//                    }
//                );
//                context.SaveChanges();
//            }
//        }
//    }
//}