using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website.ViewModel
{
    public class OffertVM
    {
        public int Id { get; set; }
        [DisplayName("Name:")]
        [Required(ErrorMessage = "*This field is Required")]
        [StringLength(50, ErrorMessage = "Must contain max 50 characters")]
        public string Name { get; set; }
        [DisplayName("Description:")]
        [StringLength(250, ErrorMessage = "Must contain max 250 characters")]
        public string Description { get; set; }
        public double Price { get; set; }

        public int CarId { get; set; }

        public int SallemenId { get; set; }

      //  public CarVM Car { get; set; }

     //   public SallemanVM Salleman { get; set; }
    }
}