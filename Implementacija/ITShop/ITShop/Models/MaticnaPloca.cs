using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class MaticnaPloca //: Proizvod
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public Proizvod Proizvod { get; set; }
        [Display(Name = "Broj RAM slotova")]
        [Required]
        [RegularExpression("^[0-9+]$", ErrorMessage = "Vrijednost nije validna.")]
        public int BrojRAMSlotova { get; set; }
        [Display(Name = "Socket procesora")]
        [Required]
        public string SocketProcesora { get; set; }

    }
}