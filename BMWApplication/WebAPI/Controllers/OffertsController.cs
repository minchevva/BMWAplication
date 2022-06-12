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
    public class OffertsController : ApiController
    {
        private OffertManagementService offertService = new OffertManagementService();


        [HttpGet]
        public IHttpActionResult Get()
        {
            return Json(offertService.Get());
        }

        //[HttpGet]
        //public IHttpActionResult GetOffertById(int id)
        //{
        //    return Json( offertService.GetOffertById(id));
        //}

        [HttpGet]
        public IHttpActionResult GetOffertById(int id)
        {
            return Json(offertService.GetOffertById(id));
        }

        //[HttpPost]
        //public IHttpActionResult Get(int id)
        //{
        //    return Json(offertService.GetOffertById(id));
        //}


        [HttpPost]
        public IHttpActionResult Save(OffertDTO offertDto)
        {
            //if (!offertDto.Validate())
            //    return Json(new ResponseMessage { Code = 500, Error = "Data is not valid!" });
            ResponseMessage response = new ResponseMessage();

            if (offertService.Save(offertDto))
            {
                response.Code = 200;
                response.Body = "Offert is saved.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Offert is not saved.";
            }

            return Json(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            ResponseMessage response = new ResponseMessage();

            if (offertService.Delete(id))
            {
                response.Code = 200;
                response.Body = "Offert is deleted.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Offert is not deleted.";
            }

            return Json(response);
        }
    }
}