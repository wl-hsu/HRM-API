using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Infrastructure.Repositories;
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


        public List<EmployeeResponseModel> GetAllEmployees()
        {
            var employees = _employeeRepository.GetAllEmployees();
            var employeesResponseModel = new List<EmployeeResponseModel>();
            foreach (var employee in employees)
            {
                employeesResponseModel.Add(new EmployeeResponseModel() { 
                    
                    Id = employee.Id, 
                    FirstName = employee.FirstName, 
                    MiddleName = employee.MiddleName, 
                    LastName = employee.LastName,
                    Email = employee.Email,
                    PersonInfo = employee.PersonInfo, 
                    Title = employee.Title, 
                    CreateOn = employee.CreateOn.GetValueOrDefault(), 
                    Department = employee.Department
                }) ;
            }
            return employeesResponseModel;
        }

        public EmployeeResponseModel GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            var employeeResponseModel = new EmployeeResponseModel()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                MiddleName = employee.MiddleName,
                LastName = employee.LastName,
                Email = employee.Email,
                PersonInfo = employee.PersonInfo,
                Title = employee.Title,
                CreateOn = employee.CreateOn.GetValueOrDefault(),
                Department = employee.Department


            };
            return employeeResponseModel;
        }
    }
}
