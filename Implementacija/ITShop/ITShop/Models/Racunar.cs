using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Racunar //: Proizvod
    {
        public Procesor Procesor { get; set; }
        public Memorija RAM { get; set; }
        public Disk Disk { get; set; }
        [Display(Name = "Matična ploča")]
        public MaticnaPloca MaticnaPloca { get; set; }
        [Display(Name = "Grafička kartica")]
        public GrafickaKartica GrafickaKartica { get; set; }
        [Display(Name = "Kućište")]
        public Kuciste Kuciste { get; set; }
        [Display(Name = "Zvučna kartica")]
        public ZvucnaKartica ZvucnaKartica { get; set; }
    }
}
