using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Data.Models
{
    public enum Status
    {
        [Display(Name = "Geen status")]
        None,

        [Display(Name = "Wordt aan gewerkt")]
        Pending,

        [Display(Name = "Afgerond")]
        Completed,

        [Display(Name = "Vertraagd")]
        Delayed
    }
}
