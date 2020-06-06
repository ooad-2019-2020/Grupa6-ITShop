using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class ZvucnaKartica : /*Proizvod,*/ ITip
    {
        [Required]
        private string Tip;
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public Proizvod ProizvodId { get; set; }

        public void setTip(string tip)
        {
            Tip = tip;
        }

        public string getTip()
        {
            return Tip;
        }
    }
}