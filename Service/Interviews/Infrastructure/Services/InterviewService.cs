using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class InterviewService: IInterviewService
    {
        private readonly IInterviewRepository _interviewRepository;

        public InterviewService(IInterviewRepository interviewRepository)
        {
            _interviewRepository = interviewRepository;
        }

        public async Task<int> AddInterview(InterviewRequestModel model)
        {
            var interviewEntity = new Interviews
            {
                BeginTime = model.BeginTime,
                CandidateEmail = model.CandidateEmail,
                CandidateFirstName = model.CandidateFirstName,
                CandidateIdentityId = model.CandidateIdentityId,
                CandidateLastName = model.CandidateLastName,
                EndTime = model.EndTime,
                SubmissionId = model.SubmissionId,
                InterviewerId = model.InterviewerId,
                InterviewTypeId = model.InterviewTypeId
            };
            var interview = await _interviewRepository.AddAsync(interviewEntity);
            return interview.Id;
        }

        public Task<List<InterviewResponseModel>> DeleteInterview(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InterviewResponseModel>> GetAllInterviews()
        {
            var interviews = await _interviewRepository.GetAllInterviews();
            var interviewResponseModels = new List<InterviewResponseModel>();
            foreach (var interview in interviews)
            {
                var interviewResponseModel = new InterviewResponseModel
                {

                    Id = interview.Id,
                    BeginTime = interview.BeginTime,
                    CandidateEmail = interview.CandidateEmail,
                    CandidateFirstName = interview.CandidateFirstName,
                    CandidateIdentityId = interview.CandidateIdentityId,
                    CandidateLastName = interview.CandidateLastName,
                    EndTime = interview.EndTime,
                    Feedback = interview.Feedback,
                    Passed = interview.Passed,
                    Rating = interview.Rating,
                    SubmissionId = interview.SubmissionId,
                    InterviewerId = interview.InterviewerId,
                    InterviewTypeId = interview.InterviewTypeId,
                };
                interviewResponseModels.Add(interviewResponseModel);
            }
            return interviewResponseModels;
        }

        public async Task<InterviewResponseModel> GetInterviewById(int id)
        {
            var interview = await _interviewRepository.GetInterviewById(id);
            var interviewResponseModel = new InterviewResponseModel
            {
                Id = interview.Id,
                BeginTime = interview.BeginTime,
                CandidateEmail = interview.CandidateEmail,
                CandidateFirstName = interview.CandidateFirstName,
                CandidateIdentityId = interview.CandidateIdentityId,
                CandidateLastName = interview.CandidateLastName,
                EndTime = interview.EndTime,
                Feedback = interview.Feedback,
                Passed = interview.Passed,
                Rating = interview.Rating,
                SubmissionId = interview.SubmissionId,
                InterviewerId = interview.InterviewerId,
                InterviewTypeId = interview.InterviewTypeId,
            };
            return interviewResponseModel;
        }

        public Task<InterviewResponseModel> UpdateInterview(int id, InterviewRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
