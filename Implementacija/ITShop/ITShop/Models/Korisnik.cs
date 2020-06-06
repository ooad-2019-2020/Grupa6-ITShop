
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public /*abstract*/ class Korisnik
    {
        public int KorisnikId { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        [Display(Name = "Korisničko ime")]
        public String KorisnickoIme { get; set; }
        public String Email { get; set; }
        public String Adresa { get; set; }
        [Display(Name = "Šifra")]
        public String Sifra { get; set; }
        [Display(Name = "Datum rođenja")]
        public DateTime DatumRodjenja { get; set; }
    }
}
