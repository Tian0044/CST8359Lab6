using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lab6.Models
{
    public class StudentBase
    {
        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [StringLength(50, MinimumLength = 1)]
        [Display(Name = "Program")]
        [Required]
        public string Program { get; set; }
    }
}
