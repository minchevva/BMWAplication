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
   public  class SallemanManagementService
    {
        public List<SallemanDTO> Get()
        {
            List<SallemanDTO> sallemanDto = new List<SallemanDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.SallemanRepository.Get())
                {
                    sallemanDto.Add(new SallemanDTO
                    {
                        Id = item.Id,
                        FirstName = item.FirstName,
                        LastName = item.LastName,
                       Email = item.Email,
                       City = item.City,
                       Age = item.Age

                    }) ;
                }
            }

            return sallemanDto;
        }
        public SallemanDTO GetSallemanById(int id)
        {
            SallemanDTO sallemanDTO = new SallemanDTO();


            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Salleman salleman = unitOfWork.SallemanRepository.GetByID(id);
                if (salleman != null)
                {
                    sallemanDTO = new SallemanDTO
                    {
                        Id = salleman.Id,
                        FirstName = salleman.FirstName,
                        LastName = salleman.LastName,
                        Email = salleman.Email,
                        City = salleman.City,
                        Age = salleman.Age

                    };
                }
            }

            return sallemanDTO;
        }

        public bool Save(SallemanDTO sallemanDto)
        {
            Salleman salleman = new Salleman
            {
                Id = sallemanDto.Id,
                FirstName = sallemanDto.FirstName,
                LastName = sallemanDto.LastName,
                Email = sallemanDto.Email,
                City = sallemanDto.City,
                Age = sallemanDto.Age


            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (sallemanDto.Id == 0)
                        unitOfWork.SallemanRepository.Insert(salleman);
                    else
                        unitOfWork.SallemanRepository.Update(salleman);
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
                    Salleman salleman = unitOfWork.SallemanRepository.GetByID(id);
                    unitOfWork.SallemanRepository.Delete(salleman);
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
