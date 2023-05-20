using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IInterviewService
    {
        Task<List<InterviewResponseModel>> GetAllInterviews();

        Task<InterviewResponseModel> GetInterviewById(int id); 

        Task<int> AddInterview(InterviewRequestModel model);

        //Task<List<InterviewResponseModel>> DeleteInterview(int id);

        //Task<InterviewResponseModel> UpdateInterview(int id, InterviewRequestModel model);
    }
}
