using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Job
    {
        public int Id { get; set; }

        [Required]
        public Guid JobCode { get; set; }


        [Required, Column(TypeName = "varchar(80)")]
        public string Title { get; set; }

        [Required, MaxLength(2048)]
        public string? Description { get; set; }

        public DateTime? StartDate { get; set; }


        public bool? isActive { get; set; }

        [Required]
        public int NumberOfPositions { get; set; }


        public DateTime? ClosedOn { get; set; }


        [MaxLength(1024)]
        public string? CloseReason { get; set; }


        public DateTime? CreatedOn { get; set; }

        [ForeignKey("JobStatusLookUpId")]
        public int jobStatusLookUpId { get; set; }


        public JobStatusLookUp JobStatusLookUp { get; set; }


    }
}
