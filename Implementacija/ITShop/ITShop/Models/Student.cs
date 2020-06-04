using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Student : Kupac
    {
        public DateTime DatumIstekaLicence { get; set; }
        public int Id { get; set; }
        public int KupacId { get; set; }

        public void isprazniKorpu(bool gotovaKorpa)
        {
            // Your code here
        }
    }
}
