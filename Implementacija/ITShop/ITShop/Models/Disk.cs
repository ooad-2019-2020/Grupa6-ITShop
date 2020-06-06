using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Disk //: Proizvod
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public Proizvod ProizvodId { get; set; }
        [RegularExpression("^[0-9+]$", ErrorMessage = "Kapacitet nije validan.")]
        [Required]
        public int Kapacitet { get; set; }
        [Required]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Brzina se predstavlja kao realan broj.")]
        public int Brzina { get; set; }
    }
}