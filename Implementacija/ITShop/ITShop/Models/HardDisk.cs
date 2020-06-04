using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class HardDisk :/* Disk,*/ ITip
    {
        public string Tip;
        public int Id { get; set; }

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
