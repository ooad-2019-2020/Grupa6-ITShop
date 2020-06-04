using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Administrator //: Uposlenik
    {
        [ForeignKey("administrator_id")]
        public int AdministratorId { get; set; }
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
