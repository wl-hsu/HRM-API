using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IJobStatusLookUpService
    {
        Task<List<JobStatusLookUpResponseModel>> GetAllStatus();
        Task<JobStatusLookUpResponseModel> GetStatusById(int id);
        Task DeleteStatus(int id);
        Task<int> AddStatus(JobStatusLookUpRequestModel model);
        Task<int> UpdateStatus(JobStatusLookUpRequestModel model, int id);
    }
}
