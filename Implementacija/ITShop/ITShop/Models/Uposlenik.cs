using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Uposlenik : Korisnik
    {
        public DateTime DatumZaposljenja { get; set; }
        [NotMapped]public List<Proizvod> ListaProizvoda { get; set; }
        public int Id { get; set; }
        public int KorisnikId { get; set; }
    }
}
