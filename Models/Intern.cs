using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SummerInternRegistration.Models
{
    public class Intern
    {
        public int ID { get; set; }
        public string PREFIX { get; set; }
        [Required]
        public string FNAME { get; set; }
        public string PMNAME { get; set; }
        [Required]
        public string LNAME { get; set; }
        public string SUFFIX { get; set; }
        [Required]
        public string EMAIL1 { get; set; }
        [Required]
        public string MOBILE { get; set; }
        [Required]
        public string MAJOR { get; set; }
        [Required]
        public string CLASSIFICATION { get; set; }
        [Required]
        public double GPA { get; set; }
        [Required]
        public string COLLEGECREDIT { get; set; }
        [Required]
        [Display (Name = "Semester Term")]
        public string SEMESTERTERM { get; set; }
        public IEnumerable<SelectListItem> SemesterTerms { get; set; }
        [Required]

        public string SEMESTERYEAR { get; set; }
        [Required]
        public string ACADEMICCREDITSEMESTER { get; set; }
        [Required]
        public string ACADEMICCREDITYEAR { get; set; }
        [Required]
        public string COLLEGEGRADUATIONSEMESTER { get; set; }
        [Required]
        public string COLLEGEGRADUATIONYEAR { get; set; }
        [Required]
        public string FNAMEPROF { get; set; }
        [Required]
        public string LNAMEPROF { get; set; }
        [Required]
        public string PREFEREDSITE { get; set; }
        [Required]
        public string DRUGSCREEN { get; set; }
        [Required]
        public string BACKGROUNDCHECK { get; set; }
        [Required]
        public string FIRSTEXPERIENCE { get; set; }
        [Required]
        public string LOCATIONOUTSIDEGA { get; set; }
        [Required]
        public string LOCATIONLODGING { get; set; }
        [Required]
        public string INTERNSHIPPREP { get; set; }
        [Required]
        public string EDITOR { get; set; }
        public string NOTES { get; set; }
        public DateTime TIMESTAMP { get; set; }

    }
}
