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
        public Korisnik KorisnikId { get; set; }
        [NotMapped] public virtual Korpa Korpa { get; set; }
        [Display(Name = "Prethodne kupovine")]
        [NotMapped] public List<Kupovina> PrethodneKupovine { get; set; }
        [NotMapped] public List<string> Poruke { get; set; }
    }
}