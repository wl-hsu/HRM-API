using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class InterviewRepository : BaseRepository<Interviews>, IInterviewRepository
    {

        public InterviewRepository(InterviewsDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Interviews>> GetAllInterviews()
        {

            var interviews = await _interviewsDbContext.Interviews.ToListAsync();
            return interviews;

        }

        public async Task<Interviews> GetInterviewById(int id)
        {

            var interviews = await _interviewsDbContext.Interviews.FirstOrDefaultAsync(j => j.Id == id);
            return interviews;


        }




    }
}
