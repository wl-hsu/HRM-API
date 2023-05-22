using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface ISubmissionService
    {
        Task<int> AddSubmission(SubmissionRequestModel model);

        Task<List<SubmissionResponseModel>> GetSubmissionsByCandidateId(int candidateId);
        Task<List<SubmissionResponseModel>> GetSubmissionsByJobId(int jobId);
        Task<List<SubmissionResponseModel>> GetAllSubmissions();

        Task<SubmissionResponseModel> GetSubmissionById(int id);

    }
}
