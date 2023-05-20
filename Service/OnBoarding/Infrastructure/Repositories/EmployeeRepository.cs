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
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(OnBoardingDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Employee>> GetAllEmployees()
        {

            var employees = await _onBoardingDbContext.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var employee = await _onBoardingDbContext.Employees.FirstOrDefaultAsync(j => j.Id == id);
            return employee;
        }
    }
}
