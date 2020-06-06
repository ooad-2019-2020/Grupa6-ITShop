using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Kupovina
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public Kupac KupacId { get; set; }
        // Mozemo imati vise proizvoda u Kupovini
        [NotMapped]
        public List<Proizvod> ListaProizvoda { get; set; }
        [Required]
        public DateTime DatumTransakcije { get; set; }
        [Required]
        public NacinPlacanjaKlasa TipPlacanja { get; set; }
        [Required]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Iznos nije validan.")]
        public double Iznos { get; set; }
    }
}