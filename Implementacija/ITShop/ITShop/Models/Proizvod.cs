using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public /*abstract*/ class Proizvod
    {
        public string Naziv { get; set; }
        public string Proizvodjac { get; set; }
        public double Cijena { get; set; }
        public int Id { get; set; }
        public string Slika { get; set; }
       [NotMapped] 
        public List<Kupac> Pratioc { get; set; }
        //Pogledaj u novoj klasi KupovinaProizvoda da vidis zasto postoji atribut Kupovine
        [NotMapped]
        public List<Kupovina> Kupovine { get; set; }

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