using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website.ViewModel
{
    public class SallemanVM
    {
        public int Id { get; set; }
        [DisplayName("First Name:")]
        [Required(ErrorMessage = "*This field is Required")]
        [StringLength(50, ErrorMessage = "Must contain max 50 characters")]
        public string FirstName { get; set; }
        [DisplayName("Last Name:")]
        [StringLength(250, ErrorMessage = "Must contain max 250 characters")]
        public string LastName { get; set; }
        [DisplayName("Email:")]
        [StringLength(30, ErrorMessage = "Must contain max 30 characters")]
        public string Email { get; set; }
        [DisplayName("City:")]
        [Required(ErrorMessage = "*This field is Required")]
        [StringLength(30, ErrorMessage = "Must contain max 30 characters")]
        public string City { get; set; }
        [DisplayName("Age:")]
        public int Age { get; set; }


        public SallemanVM() { }

        public SallemanVM(SallemanDTO sallemanDto)
        {
                Id = sallemanDto.Id;
                FirstName = sallemanDto.FirstName;
               /* LastName = sallemanDto.LastName;
                Email = sallemanDto.Email;
                City = sallemanDto.City;
                Age = sallemanDto.Age;*/

        }
    }
}