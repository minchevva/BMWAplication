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
    public class SallemansController : ApiController
    {
        private SallemanManagementService sallemanService = new SallemanManagementService();


        [HttpGet]
        public IHttpActionResult Get()
        {
            return Json(sallemanService.Get());
        }

        //[HttpGet]
        //public IHttpActionResult GetOfsallemanById(int id)
        //{
        //    return Json( sallemanService.GetSallemanById(id));
        //}

        [HttpGet]
        public IHttpActionResult GetSallemanById(int id)
        {
            return Json(sallemanService.GetSallemanById(id));
        }

        //[HttpPost]
        //public IHttpActionResult Get(int id)
        //{
        //    return Json(salemanService.GetSallemanById(id));
        //}


        [HttpPost]
        public IHttpActionResult Save(SallemanDTO sallemanDto)
        {
            //if (!sallemanDto.Validate())
            //    return Json(new ResponseMessage { Code = 500, Error = "Data is not valid!" });
            ResponseMessage response = new ResponseMessage();

            if (sallemanService.Save(sallemanDto))
            {
                response.Code = 200;
                response.Body = "Salleman is saved.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Salleman is not saved.";
            }

            return Json(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            ResponseMessage response = new ResponseMessage();

            if (sallemanService.Delete(id))
            {
                response.Code = 200;
                response.Body = "Salleman is deleted.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Salleman is not deleted.";
            }

            return Json(response);
        }
    }
}