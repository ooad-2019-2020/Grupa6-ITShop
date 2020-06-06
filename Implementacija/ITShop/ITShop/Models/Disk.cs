using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Disk //: Proizvod
    {
        [ScaffoldColumn(false)]
        public int DiskId { get; set; }
        [ScaffoldColumn(false)]
        //Ovaj atribut je ustvari id, ali kada pravis bazu, moras staviti da je tipa sa kojim zelis fk imati
        public Proizvod Proizvod { get; set; }
        [RegularExpression("^[0-9+]$", ErrorMessage = "Kapacitet nije validan.")]
        [Required]
        public int Kapacitet { get; set; }
        [Required]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Brzina se predstavlja kao realan broj.")]
        public int Brzina { get; set; }
    }
}