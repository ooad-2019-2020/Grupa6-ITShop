using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class Monitor : /*Proizvod,*/ ITip
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public Proizvod ProizvodId { get; set; }
        [Required]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Dijagonala nije validna.")]
        public double Dijagonala { get; set; }
        [Required]
        public string Rezolucija { get; set; }
        [Display(Name = "Broj HDMI")]
        [Required]
        [RegularExpression("^[0-9+]$", ErrorMessage = "Vrijednost nije validna.")]
        public int BrojHDMI { get; set; }
        [Display(Name = "Broj VGA")]
        [Required]
        [RegularExpression("^[0-9+]$", ErrorMessage = "Vrijednost nije validna.")]
        public int BrojVGA { get; set; }
        [Required]
        private string Tip;

        public void setTip(string tip)
        {
            Tip = tip;
        }
        public string getTip()
        {
                return Tip;
        }
    }
}
