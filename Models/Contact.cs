using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        public String Forename { get; set; }
        [Required]
        public String Surname { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Phone { get; set; }
        [Required]
        public String Address { get; set; }
        public String City { get; set; }
        [Required]
        public String Country { get; set; }
        [Required]
        public String Postcode { get; set; }
    }
}
