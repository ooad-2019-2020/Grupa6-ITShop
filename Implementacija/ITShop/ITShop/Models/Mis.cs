using ITShop.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Data
{
    public class Mis : Proizvod
    {
        public int Id { get; set; }
        public int ProizvodId { get; set; }
        public string VrstaPrikljucka { get; set; }
        public int DuzinaKabla { get; set; }
        public int DodatneTipke { get; set; }
    }
}