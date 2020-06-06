using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Kupac //: Korisnik
    {
        public int Id { get; set; }
        public int KorisnikId { get; set; }
        [NotMapped] public virtual Korpa Korpa { get; set; }
        [NotMapped] public List<Kupovina> PrethodneKupovine { get; set; }
        [NotMapped] public List<string> Poruke { get; set; }
    }
}