using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Offert : BaseEntity
    {
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(250), Required]
        public string Description { get; set; }
        public int CarId { get; set; }
     
        public virtual Car Car { get; set; }
        public int SallemenId { get; set; }
        public virtual Salleman Sallemen { get; set; }
      
        public double Price { get; set; }
    }
}
