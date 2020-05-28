using System.Collections.Generic;

namespace ITShop.Models
{
    public class Korpa
    {
        public List<Proizvod> ListeProizvoda { get; set; }
        public int Limit { get; set; }
        public double Iznos { get; set; }

        public void izbaciProizvod(int id)
        {
            // Your code here
        }
        public void dodajProizvod(Proizvod proizvod)
        {
            // Your code here
        }

        public void isprazniListuProizvoda()
        {
            // Your code here
        }
    }
}