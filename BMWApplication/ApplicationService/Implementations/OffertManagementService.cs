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
   public class OffertManagementService
    {
        public List<OffertDTO> Get()
        {
            List<OffertDTO> offertDto = new List<OffertDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.OffertRepository.Get())
                {
                    offertDto.Add(new OffertDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Description = item.Description,
                        Price = item.Price,
                        CarId=item.CarId,
                       /* Car = new CarDTO
                        {
                            ID = item.Car.Id,
                            Name = item.Car.Name,
                            YearOfCreattion = item.Car.YearOfCreattion,
                            EngineSize = item.Car.EngineSize,
                            Fuel = item.Car.Fuel,
                            Coupe = item.Car.Coupe,
                            Color = item.Car.Color,
                        },*/
                        SallemenId=item.SallemenId,
                        /*Sallemen = new SallemanDTO
                        {
                            Id = item.Sallemen.Id,
                            FirstName = item.Sallemen.FirstName,
                            LastName = item.Sallemen.LastName,
                            Email = item.Sallemen.Email,
                            City = item.Sallemen.City,
                            Age = item.Sallemen.Age
                        }*/
                    }) ;
                }
            }

            return offertDto;
        }
        public OffertDTO GetOffertById(int id)
        {
            OffertDTO offertDTO = new OffertDTO();


            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Offert offert = unitOfWork.OffertRepository.GetByID(id);
                if (offert != null)
                {
                    offertDTO = new OffertDTO
                    {
                        Id = offert.Id,
                        Name = offert.Name,
                        Description = offert.Description,
                        Price = offert.Price,
                        CarId=offert.CarId,
                       /* Car = new CarDTO
                        {
                            ID = offert.Car.Id,
                            Name = offert.Car.Name,
                            YearOfCreattion = offert.Car.YearOfCreattion,
                            EngineSize = offert.Car.EngineSize,
                            Fuel = offert.Car.Fuel,
                            Coupe = offert.Car.Coupe,
                            Color = offert.Car.Color,
                        },*/
                        SallemenId=offert.SallemenId,
                        /*Sallemen = new SallemanDTO
                        {
                            Id = offert.Sallemen.Id,
                            FirstName = offert.Sallemen.FirstName,
                            LastName = offert.Sallemen.LastName,
                            Email = offert.Sallemen.Email,
                            City = offert.Sallemen.City,
                            Age = offert.Sallemen.Age
                        }*/
                    };
                }
            }

            return offertDTO;
        }

        public bool Save(OffertDTO offertDto)
        {
            Offert offert = new Offert
            {
               // Id = offertDto.Id,
                Name = offertDto.Name,
                Description = offertDto.Description,
                Price = offertDto.Price,
                SallemenId = offertDto.SallemenId,

                CarId = offertDto.CarId
                
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (offertDto.Id == 0)
                        unitOfWork.OffertRepository.Insert(offert);
                    else
                        unitOfWork.OffertRepository.Update(offert);
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
                    Offert offert = unitOfWork.OffertRepository.GetByID(id);
                    unitOfWork.OffertRepository.Delete(offert);
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
