using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class InterviewResponseModel
    {
        public int Id { get; set; }

        public DateTime BeginTime { get; set; }

        public string CandidateEmail { get; set; }


        public string CandidateFirstName { get; set; }


        public string CandidateLastName { get; set; }


        public Guid CandidateIdentityId { get; set; }


        public DateTime EndTime { get; set; }

        public string? Feedback { get; set; }


        public int InterviewerId { get; set; }


        public int InterviewTypeId { get; set; }

        public int? Rating { get; set; }


        public int? Passed { get; set; }

        public int SubmissionId { get; set; }

    }
}
