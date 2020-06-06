using ITShop.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Data
{
    public class Mis 
    {
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        [Display(Name = "Vrsta priključka")]
        public string VrstaPrikljucka { get; set; }
        [Display(Name = "Dužina kabla")]
        public int DuzinaKabla { get; set; }
        [Display(Name = "Dodatne tipke")]
        public int DodatneTipke { get; set; }
    }
}