using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class RegistrationModel
    {
        [DisplayName("Your First Name")]
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [DisplayName("Your Second Name")]
        [Required]
        [MinLength(3)]
        public string Surname { get; set; }

        [DisplayName("Your Email")]
        [Required]
        [EmailAddress]
        [MaxLength(35)]
        public string Email { get; set; }

        [DisplayName("Your Age")]
        [Required]
        [Range(10, 100)]
        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
