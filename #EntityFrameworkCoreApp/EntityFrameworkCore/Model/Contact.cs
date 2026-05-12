using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Model
{
    public class Contact
    {
        public int Id  { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        public List<Email> Emails { get; set; } = new List<Email>();
        public List<Phone> Phones { get; set; } = new List<Phone>();
    }
}
