using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public enum NacinPlacanja { KreditnaKartica, Gotovina }
    public class NacinPlacanjaKlasa 
    {
        public NacinPlacanja Tip { get; set; }
    }
}
