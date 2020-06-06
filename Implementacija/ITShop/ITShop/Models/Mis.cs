using ITShop.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Data
{
    public class Mis //: Proizvod
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        //Ovaj atribut je ustvari id, ali kada pravis bazu, moras staviti da je tipa sa kojim zelis fk imati
        public Proizvod Proizvod { get; set; }
        [Display(Name = "Vrsta priključka")]
        [Required]
        public string VrstaPrikljucka { get; set; }
        [Display(Name = "Dužina kabla")]
        [Required]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Dužina nije validna.")]
        public int DuzinaKabla { get; set; }
        [Display(Name = "Dodatne tipke")]
        [Required]
        [RegularExpression("^[0-9+]$", ErrorMessage = "Vrijednost nije validna.")]
        public int DodatneTipke { get; set; }
    }
}