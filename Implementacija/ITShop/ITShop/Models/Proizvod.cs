using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public /*abstract*/ class Proizvod
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Naziv proizvoda može da sadrži slova i brojeve.")]
        public string Naziv { get; set; }
        [Required]
        public string Proizvodjac { get; set; }
        [Required]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Cijena nije validna.")]
        public double Cijena { get; set; }
        //ScaffoldCoulmn govori da ovaj atribut se ne treba koristiti u kontroleru i view-u
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Slika { get; set; }
       [NotMapped] 
        public List<Kupac> Pratioc { get; set; }
        //Pogledaj u novoj klasi KupovinaProizvoda da vidis zasto postoji atribut Kupovine
        //NotMapped znaci da se ne treba stavljati ovaj atribut kao kolona u bazi podataka
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