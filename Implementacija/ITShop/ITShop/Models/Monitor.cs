using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Monitor : Proizvod, ITip
    {
        public double Dijagonala { get; set; }
        public string Rezolucija { get; set; }
        public int BrojHDMI { get; set; }
        public int BrojVGA { get; set; }
        public string Tip;

        public string setTip(string tip)
        {
            Tip = tip;
        }
        public string getTip()
        {
                return Tip;
        }
    }
}
