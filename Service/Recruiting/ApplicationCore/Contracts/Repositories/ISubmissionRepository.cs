using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface ISubmissionRepository: IBaseRepository<Submission>
    {
        Task<List<Submission>> GetAllSubmission();
        Task<List<Submission>> GetSubmissionsByCandidateId(int candidateId);
        Task<List<Submission>> GetSubmissionsByJob(int jobId);

        Task<Submission> GetSubmissionById(int id);
    }
}
