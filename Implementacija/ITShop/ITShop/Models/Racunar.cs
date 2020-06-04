using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Racunar : Proizvod
    {
        public Procesor Procesor { get; set; }
        public Memorija RAM { get; set; }
        public Disk Disk { get; set; }
        public MaticnaPloca MaticnaPloca { get; set; }
        public GrafickaKartica GrafickaKartica { get; set; }
        public Kuciste Kuciste { get; set; }
        public ZvucnaKartica ZvucnaKartica { get; set; }
    }
}
