using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Submission
    {
        public int Id { get; set; }

        [Required, ForeignKey("JobId")]
        public int JobId { get; set; }

        [Required, ForeignKey("CandidateId")]
        public int CandidateId { get; set; }
        public DateTime? SubmittedOn { get; set; }
        public DateTime? SelectedForInterview { get; set; }
        public DateTime? RejectedOn { get; set; }
        public string? RejectionReason { get; set; }
        public Job Job { get; set; }
        public Candidate Candidate { get; set; }

    }
}
