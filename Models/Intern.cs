using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SummerInternRegistration.Models
{
    public class Intern
    {
        public int ID { get; set; }
        public string PREFIX { get; set; }
        public string FNAME { get; set; }
        public string PMNAME { get; set; }
        public string LNAME { get; set; }
        public string SUFFIX { get; set; }
        public string EMAIL1 { get; set; }
        public string MOBILE { get; set; }
        public string MAJOR { get; set; }
        public string CLASSIFICATION { get; set; }
        public double GPA { get; set; }
        public string COLLEGECREDIT { get; set; }



        public string SEMESTERTERM { get; set; }
        public string SEMESTERYEAR { get; set; }
        public string ACADEMICCREDITSEMESTER { get; set; }
        public string ACADEMICCREDITYEAR { get; set; }
        public string COLLEGEGRADUATIONSEMESTER { get; set; }
        public string COLLEGEGRADUATIONYEAR { get; set; }
        public string FNAMEPROF { get; set; }
        public string LNAMEPROF { get; set; }
        public string PREFEREDSITE { get; set; }
        public string DRUGSCREEN { get; set; }
        public string BACKGROUNDCHECK { get; set; }
        public string FIRSTEXPERIENCE { get; set; }
        public string LOCATIONOUTSIDEGA { get; set; }
        public string LOCATIONLODGING { get; set; }
        public string INTERNSHIPPREP { get; set; }
        public string EDITOR { get; set; }
        public string NOTES { get; set; }
        public DateTime TIMESTAMP { get; set; }

    }
}
