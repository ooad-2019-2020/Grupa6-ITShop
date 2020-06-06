using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ITShop.Models
{
    public class SSD : /*Disk,*/ ITip
    {
        [Required]
        private string Tip;
        [Required]
        [Display(Name = "Veličina")]
        [RegularExpression("^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Veličina nije validna.")]
        public double Velicina { get; set; }
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public Disk DiskId { get; set; }
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
