using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class JobStatusLookUpService : IJobStatusLookUpService
    {

        private readonly IJobStatusLookUpRepository _iJobStatusLookUpRepository;

        public JobStatusLookUpService(IJobStatusLookUpRepository iJobStatusLookUpRepository)
        {
            _iJobStatusLookUpRepository = iJobStatusLookUpRepository;
        }
        public Task<int> AddStatus(JobStatusLookUpRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStatus(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<JobStatusLookUpResponseModel>> GetAllStatus()
        {
            throw new NotImplementedException();
        }

        public Task<JobStatusLookUpResponseModel> GetStatusById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateStatus(JobStatusLookUpRequestModel model, int id)
        {
            throw new NotImplementedException();
        }
    }
}
