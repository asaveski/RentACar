using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Car
    {
        [Key]
        public int IDcar { get; set; }

        [Display(Name ="Vehicle Model - Year of Prod")]
        public string modelYear { get; set; }

        
        //[RegularExpression(@"^[A-Z0-9\s]+$", ErrorMessage = "Wrong input!")]
        [Display(Name = "Registration Plate No.")]
        public string registrationPlate { get; set; }

        //[RegularExpression(@"^[0-9\s]+$", ErrorMessage ="Wrong input!")]
        [Display(Name = "Cost Per Day")]
        public float pricePerDay { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

    }
}