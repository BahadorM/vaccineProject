using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class States
    {
        [Key]
        public int CityID { get; set; }
        [Required]
        [Display(Name ="استان")]
        public string CityName { get; set; }

        public virtual List<Users> Users { get; set; }
    }
}
