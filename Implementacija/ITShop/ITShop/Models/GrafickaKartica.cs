using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class GrafickaKartica //: Proizvod
    {
        public int Id { get; set; }
        public Proizvod Proizvod { get; set; }
        public int KolicinaMemorije { get; set; }
        public int BrojVentilatora { get; set; }
    }
}