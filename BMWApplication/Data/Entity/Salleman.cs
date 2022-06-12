using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
   public class Salleman : BaseEntity
    {
        [StringLength(50), Required]
        public string FirstName { get; set; }
        [StringLength(50), Required]
        public string LastName { get; set; }
        [StringLength(15)]
        public string Email { get; set; }
        [StringLength(15)]
        public string City { get; set; }
       
        public int Age { get; set; }
    }
}
