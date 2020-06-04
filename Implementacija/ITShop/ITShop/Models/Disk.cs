using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Disk //: Proizvod
    {
        public int DiskId { get; set; }
        public Proizvod Proizvod { get; set; }
        public int Kapacitet { get; set; }
        public int Brzina { get; set; }
    }
}