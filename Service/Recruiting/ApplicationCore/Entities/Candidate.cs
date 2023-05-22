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
    public class Candidate
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string? MiddleName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [Required, DataType(DataType.EmailAddress), Column(TypeName = "varchar(max)")]
        public string Email { get; set; }


        [MaxLength(2048)]
        public string? ResumeURL { get; set; }

        public DateTime? CreateOn { get; set; }

    }
}
