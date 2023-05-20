using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Employee
    {
        public int Id { get; set; }


        [Required, Column(TypeName = "varchar(max)")]
        public string? Address { get; set; }


        [Required, DataType(DataType.EmailAddress), Column(TypeName = "varchar(max)")]
        public string Email { get; set; }

        [Required]
        public Guid EmployeeIdentityId { get; set; }

        [ForeignKey("EmployeeStatusLookUpId")]
        public int EmployeeStatusId { get; set; }


        [Required, Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? HireDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? EndDate { get; set; }

        [MaxLength(50)]
        public string? MiddleName { get; set; }

        [Required, Column(TypeName = "varchar(2048)")]
        public string SSN { get; set; }


    }
}
