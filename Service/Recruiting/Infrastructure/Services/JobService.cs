using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<int> AddJob(JobRequestModel model)
        {
            var jobEntity = new Job { 
                Id = model.Id,
                Title = model.Title,
                StartDate = model.StarDate,
                Description = model.Description,
                CreatedOn = DateTime.UtcNow,
                NumberOfPositions = model.NumberOfPositions,
                jobStatusLookUpId = 1

            };
            var job = await _jobRepository.AddAsync(jobEntity);
            return job.Id;

        }

        public async Task<List<JobResponseModel>> GetAllJobs()
        {
            var jobs = await _jobRepository.GetAllJobs();
            var jobsResponseModel = new List<JobResponseModel>();
            foreach (var job in jobs)
            {
                jobsResponseModel.Add(new JobResponseModel()
                {
                    Id = job.Id,
                    Description = job.Description,
                    Title = job.Title,
                    StarDate = job.StartDate.GetValueOrDefault(),
                    NumberOfPositions = job.NumberOfPositions,
                }) ;
            }
            return jobsResponseModel;
        }

        public Task<List<JobResponseModel>> GetJobsByDepartment(int id)
        {
            throw new NotImplementedException();
        }

        /*
        public async Task<List<JobResponseModel>> GetJobsByDepartment(int id)
        {
            var jobs = await _jobRepository.GetAllJobs();
            List<JobResponseModel> jobsResponseModel = new List<JobResponseModel>();
            foreach (var job in jobs)
            {
                if(job.Department.Id == id)
                {
                    jobsResponseModel.Add(new JobResponseModel()
                    {
                        Id = job.Id,
                        Description = job.Description,
                        Title = job.Title,
                        StarDate = job.StartDate.GetValueOrDefault(),
                        NumberOfPositions = job.NumberOfPositions,
                    });
                }
            }
            return jobsResponseModel;
        }
        */

        public async Task< JobResponseModel> GetJobsById(int id)
        {
            var job = await _jobRepository.GetJobById(id);
            if (job == null)
            {
                return null;
            }
            var jobsResponseModel = new JobResponseModel
            {
                Id = job.Id,
                Description = job.Description,
                Title = job.Title,
                StarDate = job.StartDate.GetValueOrDefault(),
                NumberOfPositions = job.NumberOfPositions,
            };
            return jobsResponseModel;
        }

        public async Task<int> UpdateJob(JobRequestModel model)
        {
            var jobEntity = new Job
            {
                Id = model.Id,
                Title = model.Title,
                StartDate = model.StarDate,
                Description = model.Description,
                CreatedOn = DateTime.UtcNow,
                NumberOfPositions = model.NumberOfPositions,
                jobStatusLookUpId = 1

            };
            var job = await _jobRepository.AddAsync(jobEntity);
            return job.Id;
        }
    }
}
