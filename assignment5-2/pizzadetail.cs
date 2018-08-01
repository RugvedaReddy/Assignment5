using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace assignment5_2
{
    class pizzadetail
    { 
        [Key]
     
        public string pizzaname { get; set; }
        [Required]

        public string toppings { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public char size { get; set; }
        [Required]
        public double price  { get; set; }

    }
}
