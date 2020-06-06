using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Uposlenik //: Korisnik
    {
        [Display(Name = "Datum zaposlenja")]
        [Required]
        public DateTime DatumZaposljenja { get; set; }
        [NotMapped]public List<Proizvod> ListaProizvoda { get; set; }
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public int KorisnikId { get; set; }
    }
}
