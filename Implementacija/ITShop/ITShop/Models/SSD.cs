using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class SSD //: Disk, ITip
    {
        public string Tip;
        public double Velicina { get; set; }
        public int Id { get; set; }
        public int DiskId { get; set; }
        public void setTip(string tip)
        {
            Tip = tip;
        }

        public string getTip()
        {
            return Tip;
        }
    }
}
