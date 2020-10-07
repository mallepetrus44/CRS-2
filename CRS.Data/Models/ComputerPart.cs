using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Data.Models
{
    public class ComputerPart
    {
        public int ID { get; set; }

        [Display(Name = "Artikelnummer")]
        public int PartNumber { get; set; }

        [Display(Name = "Naam")]
        public string PartName { get; set; }

        [Display(Name = "Fabrikant")]
        public Vendor Vendor { get; set; }

        [Display(Name = "Cateogorie")]
        public Cateogory Cateogory { get; set; }

        [Display(Name = "Aantal op voorraad")]
        public int AmountInStock { get; set; }

        [Display(Name = "Prijs")]
        public double Price { get; set; }



       
    }
}
