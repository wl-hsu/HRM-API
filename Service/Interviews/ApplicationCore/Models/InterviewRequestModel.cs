using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class InterviewRequestModel
    {
        //public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Begin Time")]
        public DateTime BeginTime { get; set; }
        [Required(ErrorMessage = "Please enter Candidate Email")]
        public string CandidateEmail { get; set; }
        [Required(ErrorMessage = "Please enter Candidate's First Name")]
        [StringLength(50)]
        public string CandidateFirstName { get; set; }
        [Required(ErrorMessage = "Please enter CandidateIdentityId")]
        public Guid CandidateIdentityId { get; set; }
        [Required(ErrorMessage = "Please enter Candidate's Last Name")]
        [StringLength(50)]
        public string CandidateLastName { get; set; }

        [Required(ErrorMessage = "Please enter ending Time")]
        public DateTime EndTime { get; set; }

        public string? Feedback { get; set; }

        public bool? Passed { get; set; }

        public int? Rating { get; set; }


        [Required(ErrorMessage = "Please enter SubmissionId")]
        public int SubmissionId { get; set; }


        public int InterviewerId { get; set; }

        public int InterviewTypeId { get; set; }
    }
}
