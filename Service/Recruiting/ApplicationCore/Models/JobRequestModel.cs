using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class JobRequestModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Title of the Jobs")]
        [StringLength(250)]
        public string Title { get; set; }


        [Required(ErrorMessage = "Please enter job Description")]
        [StringLength(5000)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Please enter job start Date")]
        [DataType(DataType.Date)]
        public DateTime? StarDate { get; set; }

        //public string Department { get; set; }


        [Required(ErrorMessage="Please enter a number")]
        public int NumberOfPositions { get; set; }
    }
}
