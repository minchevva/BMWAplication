using Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
   public class CarsDbContextcs : DbContext
    {
            public DbSet<Car> Cars { get; set; }
            public DbSet<Salleman> Sallemans { get; set; }
            public DbSet<Offert> Offerts { get; set; }
        
    }
}
