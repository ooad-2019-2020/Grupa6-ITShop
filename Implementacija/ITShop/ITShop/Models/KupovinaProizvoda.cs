using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{ //U bazi imamo slucaj many to many veze
    //To znaci da jedan proizvod moze biti u vise kupovina, a jedna kupovina moze imati vise proizvoda
    //Ova klasa se pravi da bi mogli napraviti potrebnu tabelu u bazi
    //Ne treba kontroler za ovu klasu praviti, ja mislim
    public class KupovinaProizvoda
    {
        public int ProizvodId { get; set; }
        public Proizvod Proizvod { get; set; }
        public int KupovinaId { get; set; }
        public Kupovina Kupovina { get; set; }
    }
}
