using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class Turn
    {
        [Key]
        public int TurnID { get; set; }
        [Required]

        public int UserID { get; set; }
        [Required]
        [Display(Name ="تاریخ واکسیناسیون")]
        public DateTime DateTurn { get; set; }
        [Required]
        [Display(Name ="نوبت دوز")]
        public int DoseTime { get; set; }
        [Required]
        [Display(Name ="تاریخ تزریق")]
        public DateTime InjectionDate { get; set; }

    }
}
