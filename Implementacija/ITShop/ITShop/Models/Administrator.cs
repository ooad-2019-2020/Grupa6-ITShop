using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Administrator //: Uposlenik
    {
        [ScaffoldColumn(false)]
        public int AdministratorId { get; set; }
        [ScaffoldColumn(false)]
        public Uposlenik Uposlenik { get; set; }
        public void izbrisiUposlenika(int id)
        {
            // Your code here
        }

        public void dodajUposlenika(Uposlenik uposlenik)
        {
            // Your code here
        }

        public void izmijeniUposlenika(int id, Uposlenik uposlenik)
        {
            // Your code here
        }

        public void ukloniRecenziju(Proizvod proizvod, Kupac kupac)
        {
            // Your code here
        }
    }
}
