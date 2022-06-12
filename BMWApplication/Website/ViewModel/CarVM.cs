using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website.ViewModel
{
    public class CarVM
    {
        public int Id { get; set; }
        [DisplayName("Name:")]
        [Required(ErrorMessage = "*This field is Required")]
        [StringLength(50, ErrorMessage = "Must contain max 50 characters")]
        public string Name { get; set; }
        [DisplayName("Fuel:")]
        [StringLength(250, ErrorMessage = "Must contain max 250 characters")]
        public string Fuel { get; set; }
        [DisplayName("Coupe:")]
        [StringLength(30, ErrorMessage = "Must contain max 30 characters")]
        public string Coupe { get; set; }
        [DisplayName("Color:")]
        [Required(ErrorMessage = "*This field is Required")]
        [StringLength(30, ErrorMessage = "Must contain max 30 characters")]
        public string Color { get; set; }
        [DisplayName("Year Of Creattion:")]
        public int YearOfCreattion { get; set; }
        [DisplayName("Engine Size:")]
        public double EngineSize { get; set; }


        public CarVM() { }

        public CarVM(CarDTO carDto)
        {
            Id = carDto.Id;
            Name = carDto.Name;
          /*  YearOfCreattion = carDto.YearOfCreattion;
            EngineSize = carDto.EngineSize;
            Fuel = carDto.Fuel;
            Coupe = carDto.Coupe;
            Color = carDto.Color;*/
        }
    }
}


