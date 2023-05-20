using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{

    public class CandidateRepository : BaseRepository<Candidate>, ICandidateRepository
    {

        public CandidateRepository(RecruitingDbContext dbContext) : base(dbContext)
        {
            //_recruitingDbContext = dbContext;
        }



        public async Task<List<Candidate>> GetAllCandidates()
        {
            var candidates = await dbContext.Candidates.ToListAsync();
            return candidates;
        }

        public async Task<Candidate> GetCandidateById(int id)
        {
            var candidate = await dbContext.Candidates.FirstOrDefaultAsync(j => j.Id == id);
            return candidate;
        }
    }
}
