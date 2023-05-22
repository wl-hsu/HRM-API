using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class SubmissionRepository : BaseRepository<Submission>, ISubmissionRepository
    {
        public SubmissionRepository(RecruitingDbContext dbContext) : base(dbContext)
        {
            //_recruitingDbContext = dbContext;
        }

        public async Task<List<Submission>> GetAllSubmission()
        {
            var submissions = await dbContext.Submissions.ToListAsync();
            return submissions;
        }

        public async Task<Submission> GetSubmissionById(int id)
        {
            var submission = await dbContext.Submissions.FirstOrDefaultAsync(j => j.Id == id);
            return submission;
        }

        public async Task<List<Submission>> GetSubmissionsByCandidateId(int candidateId)
        {
            var submissions = await dbContext.Submissions.Where(j => j.CandidateId == candidateId).ToListAsync();
            return submissions;
        }

        public async Task<List<Submission>> GetSubmissionsByJob(int jobId)
        {
            var submissions = await dbContext.Submissions.Where(j => j.JobId == jobId).ToListAsync();
            return submissions;
        }
    }
}
