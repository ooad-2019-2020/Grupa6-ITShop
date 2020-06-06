using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Monitor //: Proizvod, ITip
    {
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        public double Dijagonala { get; set; }
        public string Rezolucija { get; set; }
        public int BrojHDMI { get; set; }
        public int BrojVGA { get; set; }
        public string Tip;

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
