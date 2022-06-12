using Data.Context;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class UnitOfWork : IDisposable
    {
        private CarsDbContextcs context = new CarsDbContextcs();
        private GenericRepository<Car> carRepository;
        private GenericRepository<Salleman> sallemanRepository;
        private GenericRepository<Offert> offertRepository;

        public GenericRepository<Car> CarRepository
        {
            get
            {
                if (this.carRepository == null)
                {
                    this.carRepository = new GenericRepository<Car>(context);
                }
                return carRepository;
            }
        }

        public GenericRepository<Salleman> SallemanRepository
        {
            get
            {
                if (this.sallemanRepository == null)
                {
                    this.sallemanRepository = new GenericRepository<Salleman>(context);
                }
                return sallemanRepository;
            }
        }

        public GenericRepository<Offert> OffertRepository
        {
            get
            {
                if (this.offertRepository == null)
                {
                    this.offertRepository = new GenericRepository<Offert>(context);
                }
                return offertRepository;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

    
