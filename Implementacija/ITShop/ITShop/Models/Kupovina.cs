using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Kupovina
    {
        public int Id { get; set; }
        // Mozemo imati vise proizvoda u Kupovini
        [NotMapped]public List<Proizvod> ListaProizvoda { get; set; }
        public DateTime DatumTransakcije { get; set; }
        public NacinPlacanjaKlasa TipPlacanja { get; set; }
        public double Iznos { get; set; }
    }
}