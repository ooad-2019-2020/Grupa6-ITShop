using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Disk //: Proizvod
    {
        [ForeignKey("disk_id")]
        public int DiskId { get; set; }
        public int Kapacitet { get; set; }
        public int Brzina { get; set; }
    }
}