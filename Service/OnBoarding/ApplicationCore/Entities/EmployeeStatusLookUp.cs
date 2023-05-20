using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class EmployeeStatusLookUp
    {
        public int Id { get; set; }


        [Required, Column(TypeName = "varchar(64)")]
        public string EmployeeStatusCode { get; set; }


        [Required, Column(TypeName = "varchar(1024)")]
        public string EmplooyeeStatusDescription { get; set; }
    }
}
