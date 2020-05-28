using System;
using System.Collections.Generic;

namespace ITShop.Models
{
    public class Kupovina
    {
        public int Id { get; set; }
        public List<Proizvod> ListaProizvoda { get; set; }
        public DateTime DatumTransakcije { get; set; }

        private NacinPlacanja tipPlacanja;

        public double Iznos { get; set; }
        internal NacinPlacanja TipPlacanja { get => tipPlacanja; set => tipPlacanja = value; }
    }
}