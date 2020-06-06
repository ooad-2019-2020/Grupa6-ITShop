using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public enum NacinPlacanja { KreditnaKartica, Gotovina }
    public class NacinPlacanjaKlasa 
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public NacinPlacanja Tip { get; set; }
    }
}
