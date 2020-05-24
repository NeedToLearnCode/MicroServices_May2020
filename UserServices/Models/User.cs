using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserServices.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Email { get; set; }

    }
}
