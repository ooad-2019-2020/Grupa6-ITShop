
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public /*abstract*/ class Korisnik
    {   [ScaffoldColumn(false)]
        public int KorisnikId { get; set; }
        [RegularExpression("^[a-zA-Z\\s]+$")]
        [Required]
        public String Ime { get; set; }
        [RegularExpression("^[a-zA-Z\\s]+$")]
        [Required]
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
