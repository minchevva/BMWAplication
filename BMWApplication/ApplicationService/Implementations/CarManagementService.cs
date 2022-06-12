using ApplicationService.DTOs;
using Data.Entity;
using Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class CarManagementService
    {
        public List<CarDTO> Get()
        {
            List<CarDTO> carDto = new List<CarDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.CarRepository.Get())
                {
                    carDto.Add(new CarDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        YearOfCreattion = item.YearOfCreattion,
                        EngineSize = item.EngineSize,
                        Fuel = item.Fuel,
                        Coupe = item.Coupe,
                        Color = item.Color,
                       
                    });
                }
            }

            return carDto;
        }
        public CarDTO GetCarById(int id)
        {
            CarDTO carDTO = new CarDTO();


            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Car car = unitOfWork.CarRepository.GetByID(id);
                if (car != null)
                {
                    carDTO = new CarDTO
                    {
                         Id = car.Id,
                        Name = car.Name,
                        YearOfCreattion = car.YearOfCreattion,
                        EngineSize = car.EngineSize,
                        Fuel = car.Fuel,
                        Coupe = car.Coupe,
                        Color = car.Color,
                       
                    };
                }
            }

            return carDTO;
        }

        public bool Save(CarDTO carDto)
        {
            Car car = new Car
            {
               // Id = carDto.Id,
                Name = carDto.Name,
                YearOfCreattion = carDto.YearOfCreattion,
                EngineSize = carDto.EngineSize,
                Fuel = carDto.Fuel,
                Coupe = carDto.Coupe,
                Color = carDto.Color
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (car.Id == 0)
                        unitOfWork.CarRepository.Insert(car);
                    else
                        unitOfWork.CarRepository.Update(car);
                    unitOfWork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Car car = unitOfWork.CarRepository.GetByID(id);
                    unitOfWork.CarRepository.Delete(car);
                    unitOfWork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    
    }
}
