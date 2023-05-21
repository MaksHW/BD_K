using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BD_Kyrsach.Models
{
    public class ConstructModel
    {
        [Required]
        [Display(Name = "FamilyId")] 
        public int FamilyId { get; set; }
        [Required]
        [Display(Name = "TypeofId")]
        public int TypeofId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }
    }
}
