using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Korpa
    {


        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public List<Proizvod> ListeProizvoda { get; set; }
        [RegularExpression("^[0-9+]$", ErrorMessage = "Limit predstavlja kapacitet proizvoda korpe.")]
        public int Limit { get; set; }
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Koristite realne brojeve.")]
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