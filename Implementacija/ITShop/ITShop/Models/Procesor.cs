﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Models
{
    public class Procesor //: Proizvod
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        //Ovaj atribut je ustvari id, ali kada pravis bazu, moras staviti da je tipa sa kojim zelis fk imati
        public Proizvod Proizvod { get; set; }
        [Required]
        [Display(Name = "Broj jezgra")]
        [RegularExpression("^[0-9+]$", ErrorMessage = "Vrijednost nije validna.")]
        public int BrojJezgra { get; set; }
        [Required]
        [Display(Name = "Brzina jezgra")]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Brzina jezgra nije validna.")]
        public int BrzinaJezgra { get; set; }
    }
}