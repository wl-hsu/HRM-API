using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IInterviewRepository: IBaseRepository<Interviews>
    {
        Task<List<Interviews>> GetAllInterviews();
        Task<Interviews> GetInterviewById(int id);

        //Task<List<Interviews>> DeleteInterview(int id);
        //Task<Interviews> UpdateInterview(int id, Interview interview);
    }
}
