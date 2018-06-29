using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "PLease, enter your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "PLease, enter your Surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "PLease, enter your email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Incorrect email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "PLease, enter your phone")]
        [RegularExpression(@"[\d]{10}", ErrorMessage = "Incorrect number (08********)")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please , notice if you will take part in the party")]
        public bool? WillAttend { get; set; }
    }
}