using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Kupovina
    {
        public int Id { get; set; }
        [NotMapped]public List<Proizvod> ListaProizvoda { get; set; }
        [Display(Name = "Datum transakcije")]
        public DateTime DatumTransakcije { get; set; }

        private NacinPlacanja tipPlacanja;

        public double Iznos { get; set; }
        internal NacinPlacanja TipPlacanja { get => tipPlacanja; set => tipPlacanja = value; }
    }
}