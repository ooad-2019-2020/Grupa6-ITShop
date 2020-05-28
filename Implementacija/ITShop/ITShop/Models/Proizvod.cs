using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using System.Collections.Generic;

namespace ITShop.Models
{
    public abstract class Proizvod
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public double Cijena { get; set; }
        public Dictionary<Kupac, string> Recenzije { get; set; }
        public int Id { get; set; }
        public string Slika { get; set; }
        public List<Kupac> Pratioc { get; set; }

        public bool dodajRecenziju(Kupac korisnik, string recenzija)
        {
            return false;
        }

        public void dodajPratioca(Kupac kupac)
        {
            // Your code here
        }

        public void obavijestiKupca(bool promijenjenaCijena)
        {
            // Your code here
        }
    }
}