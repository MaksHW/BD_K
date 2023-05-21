using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_Kyrsach.Models
{
    public class OrderModel
    {
        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        [Required]
        [Display(Name = "FurnitureId")]
        public int FurnitureId { get; set; }
        [Display(Name = "UserId")]
        public int UserId { get; set; }
    }
}
