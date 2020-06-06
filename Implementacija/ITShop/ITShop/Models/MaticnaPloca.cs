using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class MaticnaPloca //: Proizvod
    {
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        public int BrojRAMSlotova { get; set; }
        public string SocketProcesora { get; set; }

    }
}