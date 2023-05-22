﻿using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IJobRepository: IBaseRepository<Job>
    {
        Task<List<Job>> GetAllJobs();

        Task <Job> GetJobById(int id);

        Task<List<Job>> GetJobsByKeyword(string Keyword);
    }
}
