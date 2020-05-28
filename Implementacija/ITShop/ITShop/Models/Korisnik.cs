
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public abstract class Korisnik
    {
        public int Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String KorisnickoIme { get; set; }
        public String Email { get; set; }
        public String Adresa { get; set; }
        public String Sifra { get; set; }
        public DateTime DatumRodjenja { get; set; }
    }
}
