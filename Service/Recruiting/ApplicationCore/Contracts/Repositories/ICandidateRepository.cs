using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface ICandidateRepository: IBaseRepository<Candidate>
    {
        Task<List<Candidate>> GetAllCandidates();

        Task<Candidate> GetCandidateById(int id);


    }
}
