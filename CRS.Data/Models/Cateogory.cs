using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Data.Models
{
    public enum Cateogory
    {
        [Display(Name ="Geen")]
        None,

        [Display(Name = "Behuizing")]
        Case,

        [Display(Name = "Moederbord")]
        Motherboard,

        [Display(Name = "Processor")]
        CPU,

        [Display(Name = "Grafische kaart")]
        GPU,

        [Display(Name = "Intern Geheugen")]
        RAM,

        [Display(Name = "Opslag")]
        StorageDevice,

        [Display(Name = "Koeling")]
        Cooling,

        [Display(Name = "Voeding")]
        PSU,

        [Display(Name = "Monitor")]
        DisplayDevice,

        [Display(Name = "Besturingsprogramma")]
        OperatingSystem,

        [Display(Name = "Invoerapparaat")]
        InputDevices,

        [Display(Name = "Andere werkzaamheden")]
        Other


    }
}
