using ITShop.Models;

namespace ITShop.Data
{
    public class Mis : Proizvod
    {
        public int Id { get; set; }
        public string VrstaPrikljucka { get; set; }
        public int DuzinaKabla { get; set; }
        public int DodatneTipke { get; set; }
    }
}