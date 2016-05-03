using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Invitation.Models
{
    public class Response
    {
        [Required(ErrorMessage = "Please insert your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please insert your email.")]
        [RegularExpression("^([\\w.\\w]+)@([\\w]+)((.(\\w){2,3})+)$", ErrorMessage = "Enter correct email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please insert your phone number.")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Please Use numbers only and 10 digits.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please select an option.")]
        public bool? WillAttend { get; set; }

    }
}