using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Data.Models
{
    public enum Department
    {
         [Display(Name ="Geen")]
         None,

        [Display(Name = "Services")]
        Services,

        [Display(Name = "Verkoop")]
        Sales,

        [Display(Name = "Reparatie")]
        Repair,

        [Display(Name = "Kantoor")]
        Office



}
}
