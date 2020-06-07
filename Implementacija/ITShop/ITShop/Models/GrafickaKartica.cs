using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class GrafickaKartica //: Proizvod
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Naziv proizvoda može da sadrži slova i brojeve.")]
        public string Naziv { get; set; }
        [Required]
        [Display(Name = "Proizvođač")]
        public string Proizvodjac { get; set; }
        [Required]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Cijena nije validna.")]
        public double Cijena { get; set; }
        //[ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        //Ovaj atribut je ustvari id, ali kada pravis bazu, moras staviti da je tipa sa kojim zelis fk imati
        public Proizvod Proizvod { get; set; }
        [Display(Name = "Količina memorije")]
        [Required]
        [RegularExpression("^[0-9+]$", ErrorMessage = "Memorija je cjelobrojna vrijednost.")]
        public int KolicinaMemorije { get; set; }
        [Display(Name = "Broj ventilatora")]
        [Required]
        [RegularExpression("^[0-9+]$", ErrorMessage = "Broj ventilatora mora biti cjelobrojan.")]
        public int BrojVentilatora { get; set; }
    }
}