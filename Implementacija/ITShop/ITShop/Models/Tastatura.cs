using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Tastatura : Proizvod
    {
        public string VrstaPrikljucka { get; set; }
        public int Id { get; set; }
        public int ProizvodId { get; set; }
    }
}
