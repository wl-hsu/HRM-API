using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class JobStatusLookUpRequestModel
    {

        public string JobStatusCode { get; set; }
        public string JobStatusDescription { get; set; }
    }
}
