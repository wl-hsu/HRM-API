using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model
{
    public class EmployeeRequestModel
    {


        public string? Address { get; set; }


        public string Email { get; set; }

        public Guid EmployeeIdentityId { get; set; }

        public int EmployeeStatusId { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? HireDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? MiddleName { get; set; }

        public string SSN { get; set; }
    }
}
