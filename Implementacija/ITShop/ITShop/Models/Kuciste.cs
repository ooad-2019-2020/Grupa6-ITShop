using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Kuciste : Proizvod
    {
        public double Zapremina { get; set; }
        public int BrojPortova { get; set; }
    }
}
