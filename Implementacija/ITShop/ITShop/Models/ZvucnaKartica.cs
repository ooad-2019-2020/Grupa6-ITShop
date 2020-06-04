using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class ZvucnaKartica : Proizvod, ITip
    {
        public string Tip;
        public int Id { get; set; }
        public int ProizvodId { get; set; }

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