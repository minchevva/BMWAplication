using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearOfCreattion { get; set; }
        public int EngineSize { get; set; }
        public string Fuel { get; set; }
        public string Coupe { get; set; }
        public string Color { get; set; }
        
    }
}
