using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IDepartmentRepository
    {

        Task<List<JobResponseModel>> GetAllDepartments();
        Task<JobResponseModel> GetDepartmentById(int id);
    }
}
