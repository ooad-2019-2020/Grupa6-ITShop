using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Procesor //: Proizvod
    {
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        [Display(Name = "Broj jezgra")]
        public int BrojJezgra { get; set; }
        [Display(Name = "Brzina jezgra")]
        public int BrzinaJezgra { get; set; }
    }
}