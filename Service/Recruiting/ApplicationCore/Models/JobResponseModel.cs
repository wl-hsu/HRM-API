﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class JobResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime? StarDate { get; set; }


        //public JobStatusLookUp JobStatusLookUp { get; set; }


        //public string JobStatusDescription { get; set; }



        //public string Department { get; set; }

        public int NumberOfPositions { get; set; }
    }
}
