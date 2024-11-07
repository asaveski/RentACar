using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Reservation
    {
        [Key]
        public int IDreservation { get; set; }

        //[RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Wrong input!")]
        [Display(Name = "Total Days")]
        public int days { get; set; }

        //[RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Wrong input!")]
        [Display(Name = "Desired Address")]
        public string reservationAddress { get; set; }

       
        //[RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Wrong input!")]
        [Display(Name = "Driving License No.")]
        public int numberOfDrivingLicense { get; set; }

        //[StringLength(15, ErrorMessage = "Licence Plate No. {0} must contain {2} numerals", MinimumLength = 10)]
        //[RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Wrong input!")]
        [Display(Name = "Phone No.")]
        public string phoneNumber { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string ApplicationUserID { get; set; }

        public Car Car { get; set; }

        [Display(Name = "Car You Would Like")]
        public int IDcar { get; set; }

        [Display(Name = "Full Price")]
        public int fullPrice { get; set; }

    }
}