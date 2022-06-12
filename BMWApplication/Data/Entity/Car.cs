using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
   public class Car : BaseEntity
    {
        [StringLength(50), Required]
        public string Name { get; set; }
        public int YearOfCreattion { get; set; }
        public int EngineSize { get; set; }
        [StringLength(15)]
        public string Fuel { get; set; }
        [StringLength(15)]
        public string Coupe { get; set; }
        [StringLength(15)]
        public string Color { get; set; }

    }
}
