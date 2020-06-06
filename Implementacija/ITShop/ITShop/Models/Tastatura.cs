using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Tastatura //: Proizvod
    {
        [Display(Name = "Vrsta priključka")]
        [Required]
        public string VrstaPrikljucka { get; set; }
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public Proizvod ProizvodId { get; set; }
    }
}
