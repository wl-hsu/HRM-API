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

    public class CandidateRepository : ICandidateRepository
    {
        private RecruitingDbContext _recruitingDbContext;
        public CandidateRepository(RecruitingDbContext recruitingDbContext)
        {
            _recruitingDbContext = recruitingDbContext;
        }
        public List<Candidate> GetAllCandidates()
        {
            var candidates =  _recruitingDbContext.Candidates.ToList();
            return candidates;
        }

        public Candidate GetCandidateById(int id)
        {
            var candidate = _recruitingDbContext.Candidates.FirstOrDefault(j => j.Id == id);
            return candidate;
        }
    }
}
