using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Memorija : /*Proizvod,*/ ITip
    {
        [RegularExpression("^[0-9+]$", ErrorMessage = "Vrijednost nije validna.")]
        [Required]
        public int Kolicina { get; set; }
        [Required]
        private string Tip;
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public Proizvod Proizvod { get; set; }

        public void setTip(string Tip)
        {
            this.Tip = Tip;
        } 

        public string getTip()
        {
            return Tip;
        }
    }
}