using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Interviews
    {

        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime BeginTime { get; set; }

        [Required, DataType(DataType.EmailAddress), Column(TypeName = "varchar(max)")]
        public string CandidateEmail { get; set; }


        [Required, Column(TypeName = "varchar(50)")]
        public string CandidateFirstName { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string CandidateLastName { get; set;}


        [Required]
        public Guid CandidateIdentityId { get; set; }


        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime EndTime { get; set; }

        [MaxLength]
        public string? Feedback { get; set; }

        [ForeignKey("InterviewerId")]
        [Required]
        public int InterviewerId { get; set; }

        [Required]
        [ForeignKey("InterviewTypeCode")]
        public int InterviewTypeId { get; set; }

        public int? Rating { get; set; }


        public int? Passed { get; set; }


        [Required]
        public int SubmissionId { get; set; }


    }
}
