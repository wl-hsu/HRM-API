using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> AddEmployee(EmployeeRequestModel model)
        {
            var employeeEntity = new Employee
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                SSN = model.SSN,
                Address = model.Address,
                EmployeeIdentityId = model.EmployeeIdentityId,
                HireDate = model.HireDate,
                EndDate = model.EndDate,
                MiddleName = model.MiddleName,
                EmployeeStatusId = model.EmployeeStatusId
            };
            var employee = await _employeeRepository.AddAsync(employeeEntity);
            return employee.Id;
        }

        public async Task<List<EmployeeResponseModel>> GetAllEmployees()
        {
            var employees = await _employeeRepository.GetAllEmployees();
            var employeeResponseModels = new List<EmployeeResponseModel>();
            foreach (var employee in employees)
            {
                var employeeResponseModel = new EmployeeResponseModel
                {
                    Id = employee.Id,
                    Email = employee.Email,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    LastName = employee.LastName,
                    SSN = employee.SSN,
                    Address = employee.Address,
                    EmployeeIdentityId = employee.EmployeeIdentityId,
                    HireDate = employee.HireDate,
                    EndDate = employee.EndDate,
                    EmployeeStatusId = employee.EmployeeStatusId
                    
                };
                employeeResponseModels.Add(employeeResponseModel);
            }
            return employeeResponseModels;
        }

        public async Task<EmployeeResponseModel> GetEmployeeById(int id)
        {
            var employee = await _employeeRepository.GetEmployeeById(id);
            var employeeResponseModel = new EmployeeResponseModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                SSN = employee.SSN,
                Address = employee.Address,
                EmployeeIdentityId = employee.EmployeeIdentityId,
                HireDate = employee.HireDate,
                EndDate = employee.EndDate,
                MiddleName = employee.MiddleName,
                EmployeeStatusId = employee.EmployeeStatusId
            };
            return employeeResponseModel;
        }
    }
}
