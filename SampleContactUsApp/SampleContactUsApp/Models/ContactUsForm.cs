using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleContactUsApp.Models
{
    public class ContactUsForm
    {
        [Required(ErrorMessage = "Please Provide First Name!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Provide Last Name!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Provide Email Address!")]
        [EmailAddress(ErrorMessage = "Please Provide Correct Email Formate!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Provide Message")]
        public string Message { get; set; }
    }
}