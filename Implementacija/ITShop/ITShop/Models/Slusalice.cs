using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Slusalice //: Proizvod
    {
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        public string VrstaPrikljucka { get; set; }
        public bool ImaLiMikrofon { get; set; }
    }
}
