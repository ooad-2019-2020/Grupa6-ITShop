using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Kuciste //: Proizvod
    {
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        public double Zapremina { get; set; }
        [Display(Name = "Broj portova")]
        public int BrojPortova { get; set; }
    }
}
