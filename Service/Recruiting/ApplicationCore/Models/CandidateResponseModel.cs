using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class CandidateResponseModel
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string? ResumeURL { get; set; }

        public DateTime CreateOn { get; set; }

        public List<Submission> Submissions { get; set; }
    }
}
