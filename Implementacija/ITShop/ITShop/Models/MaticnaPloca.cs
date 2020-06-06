using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class MaticnaPloca //: Proizvod
    {
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        [Display(Name = "Broj RAM slotova")]
        public int BrojRAMSlotova { get; set; }
        [Display(Name = "Socket procesora")]
        public string SocketProcesora { get; set; }

    }
}