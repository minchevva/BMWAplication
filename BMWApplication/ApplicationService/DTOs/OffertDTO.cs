using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
   public class OffertDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
         public string Description { get; set; }
        public int CarId { get; set; }
      //  public  CarDTO Car { get; set; }
        public int SallemenId { get; set; }
        //public  SallemanDTO Sallemen { get; set; }
        public double Price { get; set; }
    }
}
