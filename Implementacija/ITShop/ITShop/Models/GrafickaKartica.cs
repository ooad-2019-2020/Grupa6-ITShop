using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class GrafickaKartica //: Proizvod
    {
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        [Display(Name = "Količina memorije")]
        public int KolicinaMemorije { get; set; }
        [Display(Name = "Broj ventilatora")]
        public int BrojVentilatora { get; set; }
    }
}