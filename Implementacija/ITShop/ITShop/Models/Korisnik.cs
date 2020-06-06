
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
        [Required]
        [RegularExpression("^[a-zA-Z0-9]+$")]
        public String KorisnickoIme { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public String Email { get; set; }
        [Required]
        public String Adresa { get; set; }
        [Required]
        [Display(Name = "Šifra")]
        public String Sifra { get; set; }
        [Required]
        [Display(Name = "Datum rođenja")]
        public DateTime DatumRodjenja { get; set; }
    }
}
