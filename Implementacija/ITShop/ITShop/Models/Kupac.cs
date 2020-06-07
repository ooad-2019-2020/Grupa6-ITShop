using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Kupac //: Korisnik
    {

        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "Ime može da sadrži samo slova.")]
        [Required]
        public String Ime { get; set; }
        [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "Prezime može da sadrži samo slova.")]
        [Required]
        public String Prezime { get; set; }
        [Display(Name = "Korisničko ime")]
        //[Required]
        // Korisnicko ime moze samo da sadrzi slova i brojeve
       // [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Korisničko ime može da sadrži slova i brojeve.")]
        public String KorisnickoIme { get; set; }
        [Required]
        //Sa interneta skinuo regex za validaciju email adrese
        //[RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email adresa nije validna.")]
        public String Email { get; set; }
        [Required]
        public String Adresa { get; set; }
        [Required]
        [Display(Name = "Šifra")]
        //Regex kod za provjeru da li sifra ima veliko, malo slovo, broj i poseban znak
        //[RegularExpression("^(?=.*[a - z])(?=.*[A - Z])(?=.*\\d)(?=.*[^\\da - zA - Z])", ErrorMessage = "Šifra mora da sadrži veliko, malo slovo," +
        //   " cifru i poseban znak.")]
        [MinLength(6, ErrorMessage = "Vaša šifra mora imati najmanje 6 karaktera.")]
        [MaxLength(15, ErrorMessage = "Vaša šifra može imati najviše 15 karaktera.")]
        public String Sifra { get; set; }

        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        //Ovaj atribut je ustvari id, ali kada pravis bazu, moras staviti da je tipa sa kojim zelis fk imati
        public Korisnik Korisnik { get; set; }
        [NotMapped] public virtual Korpa Korpa { get; set; }
        [Display(Name = "Prethodne kupovine")]
        [NotMapped] public List<Kupovina> PrethodneKupovine { get; set; }
        [NotMapped] public List<string> Poruke { get; set; }
    }
}