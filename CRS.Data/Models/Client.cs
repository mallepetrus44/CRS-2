using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Data.Models
{
    public class Client
    {
        public int ID { get; set; }

        [Display(Name="Volledige naam")]
        public string Fullname { get { return string.Concat(FirstName + "" + InFix + "" + LastName); } }

        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }

        [Display(Name = "Tussenvoegsel(s)")]
        public string InFix { get; set; }

        [Display(Name = "Achternaam")]
        public string LastName { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Woonplaats")]
        public string City { get; set; }

        [Display(Name = "Telefoonnummer")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Aantal orders")]
        public int TotalOrders { get; set; }
        public virtual ICollection<RepairOrder> RepairOrders { get; set; }


    }
}
