using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebAPI.Messages;

namespace WebAPI.Controllers
{
    public class CarsController : ApiController
    {
        private CarManagementService carService = new CarManagementService();


        [HttpGet]
        public IHttpActionResult Get()
        {
            return Json(carService.Get());
        }

        //[HttpGet]
        //public IHttpActionResult GetCarById(int id)
        //{
        //    return Json(carService.GetCarById(id));
        //}

        [HttpGet]
        public IHttpActionResult GetCarById(int id)
        {
            return Json(carService.GetCarById(id));
        }

        //[HttpPost]
        //public IHttpActionResult Get(int id)
        //{
        //    return Json(carService.GetCarById(id));
        //}


        [HttpPost]
        public IHttpActionResult Save(CarDTO carDto)
        {
            //if (!carDto.Validate())
            //    return Json(new ResponseMessage { Code = 500, Error = "Data is not valid!" });
            ResponseMessage response = new ResponseMessage();

            if (carService.Save(carDto))
            {
                response.Code = 200;
                response.Body = "Car is saved.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Car is not saved.";
            }

            return Json(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            ResponseMessage response = new ResponseMessage();

            if (carService.Delete(id))
            {
                response.Code = 200;
                response.Body = "Car is deleted.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Car is not deleted.";
            }

            return Json(response);
        }
    }
}