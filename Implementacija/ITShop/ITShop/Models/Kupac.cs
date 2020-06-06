using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Kupac //: Korisnik
    {
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