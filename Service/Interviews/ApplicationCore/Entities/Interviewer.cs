using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Interviewer
    {
        public int Id { get; set; }

        [Required]
        public Guid EmployeeIdentityId { get; set; }


        [Required, DataType(DataType.EmailAddress), Column(TypeName = "varchar(max)")]
        public string Email { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }
    }
}
