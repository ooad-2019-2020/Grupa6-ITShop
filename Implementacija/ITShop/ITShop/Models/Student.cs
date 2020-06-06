using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Student //: Kupac
    {
        [Display(Name = "Datum isteka licence")]
        [Required]
        public DateTime DatumIstekaLicence { get; set; }
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public Kupac KupacId { get; set; }

        public void isprazniKorpu(bool gotovaKorpa)
        {
            // Your code here
        }
    }
}
