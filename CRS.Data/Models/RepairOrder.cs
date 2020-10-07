using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Data.Models
{
    public class RepairOrder
    {
        public int ID { get; set; }

        [Display(Name = "Titel opdracht")]
        public string OrderTitle { get; set; }

        [Display(Name = "Opdracht Omschrijving")]
        public string OrderDescription { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Startdatum")]
        public DateTime StartDate { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Einddatum")]
        public DateTime EndDate { get; set; }

        public Status Status { get; set; }

        public virtual Client Client { get; set; }

        public virtual ICollection<RepairOrder> RepairOrders { get; set; }


    }
}
