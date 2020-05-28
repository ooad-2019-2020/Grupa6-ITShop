using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    interface IUposlenikProizvod
    {
        public void DodajProizvod(Proizvod proizvod);
        public void ObrisiProizvod(int idProizvoda);
        public Proizvod IzmijeniProizvod(int id, Proizvod proizvod);
    }
}
