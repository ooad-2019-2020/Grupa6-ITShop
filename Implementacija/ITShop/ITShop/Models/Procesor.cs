using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Procesor //: Proizvod
    {
        [Required]
        [RegularExpression("^^[A-Za-z0-9 _]*[A-Za-z0-9][A-Za-z0-9 _]*$", ErrorMessage = "Naziv proizvoda može da sadrži slova i brojeve.")]
        public string Naziv { get; set; }
        [Required]
        [Display(Name = "Proizvođač")]
        public string Proizvodjac { get; set; }
        [Required]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Cijena nije validna.")]
        public double Cijena { get; set; }
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        //Ovaj atribut je ustvari id, ali kada pravis bazu, moras staviti da je tipa sa kojim zelis fk imati
        public Proizvod Proizvod { get; set; }
        [Required]
        [Display(Name = "Broj jezgra")]
        [RegularExpression("^[0-9+]$", ErrorMessage = "Vrijednost nije validna.")]
        public int BrojJezgra { get; set; }
        [Required]
        [Display(Name = "Brzina jezgra")]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Brzina jezgra nije validna.")]
        public int BrzinaJezgra { get; set; }
    }
}