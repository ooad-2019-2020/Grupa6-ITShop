
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
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "Ime može da sadrži samo slova.")]
        [Required]
        public String Ime { get; set; }
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "Prezime može da sadrži samo slova.")]
        [Required]
        public String Prezime { get; set; }
        [Display(Name = "Korisničko ime")]
        [Required]
        // Korisnicko ime moze samo da sadrzi slova i brojeve
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Korisničko ime može da sadrži slova i brojeve.")]
        public String KorisnickoIme { get; set; }
        [Required]
        //Sa interneta skinuo regex za validaciju email adrese
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email adresa nije validna.")]
        public String Email { get; set; }
        [Required]
        public String Adresa { get; set; }
        [Required]
        [Display(Name = "Šifra")]
        //Regex kod za provjeru da li sifra ima veliko, malo slovo, broj i poseban znak
        [RegularExpression("^(?=.*[a - z])(?=.*[A - Z])(?=.*\\d)(?=.*[^\\da - zA - Z])", ErrorMessage = "Šifra mora da sadrži veliko, malo slovo," +
            " cifru i poseban znak.")]
        [MinLength(8, ErrorMessage = "Vaša šifra mora imati najmanje 8 karaktera.")]
        [MaxLength(15, ErrorMessage = "Vaša šifra može imati najviše 15 karaktera.")]
        public String Sifra { get; set; }
        [Required]
        [Display(Name = "Datum rođenja")]
        public DateTime DatumRodjenja { get; set; }
    }
}
