using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        [MaxLength(250)]
        public int OrderAmount { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
    }
}
