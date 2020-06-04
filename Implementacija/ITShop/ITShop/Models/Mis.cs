using ITShop.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITShop.Data
{
    public class Mis //: Proizvod
    {
        [ForeignKey("mis_id")]
        public int Id { get; set; }
        public string VrstaPrikljucka { get; set; }
        public int DuzinaKabla { get; set; }
        public int DodatneTipke { get; set; }
    }
}