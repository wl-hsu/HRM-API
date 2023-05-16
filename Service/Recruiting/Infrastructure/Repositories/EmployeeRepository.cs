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
    public class EmployeeRepository : IEmployeeRepository
    {

        private RecruitingDbContext _recruitingDbContext;
        public EmployeeRepository(RecruitingDbContext recruitingDbContext)
        {
            _recruitingDbContext = recruitingDbContext;
        }
        public List<Employee> GetAllEmployees()
        {
            var employees =  _recruitingDbContext.Employees.ToList();
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
