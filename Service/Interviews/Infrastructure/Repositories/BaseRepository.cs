using ApplicationCore.Contracts.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected InterviewsDbContext _interviewsDbContext;

        public BaseRepository(InterviewsDbContext recruitingDbContext)
        {
            _interviewsDbContext = recruitingDbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            _interviewsDbContext.Set<T>().Add(entity);
            await _interviewsDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _interviewsDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _interviewsDbContext.Set<T>().FindAsync(id);
        }

        public async Task<bool> GetExistsAsync(Expression<Func<T, bool>>? filter = null)
        {
            if (filter == null)
            {
                return false;
            }
            return await _interviewsDbContext.Set<T>().Where(filter).AnyAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
