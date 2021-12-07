using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [Display(Name = "شماره ملی")]
        public int NationalNumber { get; set; }
        [Required]
        [Display(Name = "تاریخ تولد")]
        [DataType(DataType.DateTime)]
        public DateTime DateBrith { get; set; }
        [Required]
        [Display(Name = "شماره موبایل")]
        public long PhoneNumber { get; set; }
        [Required]
        [Display(Name = "استان")]
        public int CityID { get; set; }
        [Required]
        [Display(Name = "کد امنیتی")]
        public int SecurityCode { get; set; }

        public virtual List<Turn> Turn { get; set; }
    }
}
