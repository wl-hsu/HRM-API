using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string MiddleName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(512)]
        public string Email { get; set; }

        [MaxLength(80)]
        public string Title { get; set; }

        [MaxLength(80)]
        public string Department { get; set; }


        [MaxLength(2048)]
        public string? PersonInfo { get; set; }

        public DateTime? CreateOn { get; set; }

    }
}
