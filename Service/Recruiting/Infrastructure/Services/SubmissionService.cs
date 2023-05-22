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
    public class SubmissionService : ISubmissionService
    {
        private readonly ISubmissionRepository _iSubmissionRepository;

        public SubmissionService(ISubmissionRepository iSubmissionRepository)
        {
            _iSubmissionRepository = iSubmissionRepository;
        }
        public async Task<int> AddSubmission(SubmissionRequestModel model)
        {
            var submissionEntity = new Submission()
            {
                CandidateId = model.CandidateId,
                JobId = model.JobId,
                SubmittedOn = DateTime.UtcNow,
                SelectedForInterview = model.SelectedForInterview,
                RejectedOn = model.RejectedOn,
                RejectionReason = model.RejectionReason
            };
            var submission = await _iSubmissionRepository.AddAsync(submissionEntity);
            return submission.Id;
        }

        public async Task<List<SubmissionResponseModel>> GetAllSubmissions()
        {
            var submissions = await _iSubmissionRepository.GetAllSubmission();
            var submissionResponseModel = new List<SubmissionResponseModel>();
            foreach (var submission in submissions)
            {
                submissionResponseModel.Add(new SubmissionResponseModel()
                {
                    Id = submission.Id,
                    JobId = submission.JobId,
                    CandidateId = submission.JobId,
                    SubmittedOn = submission.SubmittedOn,
                    SelectedForInterview = submission.SelectedForInterview,
                    RejectedOn = submission.RejectedOn,
                    RejectedReason = submission.RejectionReason
                });
            }

            return submissionResponseModel;
        }

        public async Task<SubmissionResponseModel> GetSubmissionById(int id)
        {
            var submission = await _iSubmissionRepository.GetSubmissionById(id);
            var submissionResponseModel = new SubmissionResponseModel()
            {
                Id = submission.Id,
                JobId = submission.JobId,
                CandidateId = submission.JobId,
                SubmittedOn = submission.SubmittedOn,
                SelectedForInterview = submission.SelectedForInterview,
                RejectedOn = submission.RejectedOn,
                RejectedReason = submission.RejectionReason
            };
            return submissionResponseModel;
        }

        public async Task<List<SubmissionResponseModel>> GetSubmissionsByCandidateId(int candidateId)
        {
            var submissionModel = new List<SubmissionResponseModel>();
            var submissions = await _iSubmissionRepository.GetSubmissionsByCandidateId(candidateId);
            foreach (var submission in submissions)
            {
                submissionModel.Add(new SubmissionResponseModel()
                {
                    Id = submission.Id,
                    JobId = submission.JobId,
                    CandidateId = submission.JobId,
                    SubmittedOn = submission.SubmittedOn,
                    SelectedForInterview = submission.SelectedForInterview,
                    RejectedOn = submission.RejectedOn,
                    RejectedReason = submission.RejectionReason
                });
            }

            return submissionModel;
        }

        public async Task<List<SubmissionResponseModel>> GetSubmissionsByJobId(int jobId)
        {
            var submissionModel = new List<SubmissionResponseModel>();
            var submissions = await _iSubmissionRepository.GetSubmissionsByJob(jobId);
            foreach (var submission in submissions)
            {
                submissionModel.Add(new SubmissionResponseModel()
                {
                    Id = submission.Id,
                    JobId = submission.JobId,
                    CandidateId = submission.JobId,
                    SubmittedOn = submission.SubmittedOn,
                    SelectedForInterview = submission.SelectedForInterview,
                    RejectedOn = submission.RejectedOn,
                    RejectedReason = submission.RejectionReason
                });
            }

            return submissionModel;
        }
    }
}
