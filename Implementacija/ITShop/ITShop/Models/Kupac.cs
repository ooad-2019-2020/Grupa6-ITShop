using System.Collections.Generic;

namespace ITShop.Models
{
    public class Kupac : Korisnik
    {
        public int Id { get; set; }
        public virtual Korpa Korpa { get; set; }
        public List<Kupovina> PrethodneKupovine { get; set; }
        public List<string> Poruke { get; set; }
    }
}