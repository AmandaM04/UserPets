using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSample.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }

        [Required]
        [Display(Name="Pet Species")]
        public string Species { get; set; }

        [Required]
        [Display(Name="Pet Name")]
        public string Name { get; set; }

        [Display(Name="Owner")]
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
