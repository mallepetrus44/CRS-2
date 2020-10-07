using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Data.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Display(Name = "Volledige naam")]
        public string FullName { get { return string.Concat(FirstName + "" + InFix + "" + LastName); } }

        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }

        [Display(Name = "Tussenvoegsel(s)")]
        public string InFix { get; set; }

        [Display(Name = "Achternaam")]
        public string LastName { get; set; }

        [Display(Name = "Geboortedatum")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Afdeling")]
        public Department Department { get; set; }

        [Display(Name = "Aantal orders")]
        public int OrderCount { get; set; }

        [Display(Name = "Uurloon")]
        public double Wage { get; set; }

    }
}
