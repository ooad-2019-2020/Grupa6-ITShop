using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Uposlenik : Korisnik
    {
        public DateTime DatumZaposljenja { get; set; }
        public List<Proizvod> ListaProizvoda { get; set; }
        public int Id { get; set; }
    }
}
