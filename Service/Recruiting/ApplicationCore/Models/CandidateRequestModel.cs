using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class CandidateRequestModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter firstname")]
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }


        [Required(ErrorMessage = "Please enter lastname")]
        public string LastName { get; set; }


        [Required]
        public string Email { get; set; }

        public string? ResumeURL { get; set; }
    }
}
