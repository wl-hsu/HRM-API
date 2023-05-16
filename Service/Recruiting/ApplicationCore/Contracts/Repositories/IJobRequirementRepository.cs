using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    internal interface IJobRequirementRepository
    {
        JobResponseModel GetJobById(int jobId);
        IEnumerable<JobResponseModel> GetAllJob();
        Task<IEnumerable<JobResponseModel>> GetPaginatedJobs(int pageSize = 30, int pageNumber = 1);
    }
}
