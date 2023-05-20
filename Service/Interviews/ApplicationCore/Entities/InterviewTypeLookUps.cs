using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class InterviewTypeLookUps
    {
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string InterviewTypeCode { get; set; }

        [Required, Column(TypeName = "varchar(256)")]
        public string InterviewTypeDescription { get; set; }
    }
}
