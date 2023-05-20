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
    public class CandidateService : ICandidateService
    {

        private readonly ICandidateRepository _candidateRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }
        public async Task<int> AddCandidate(CandidateRequestModel model)
        {
            var candidateEntity = new Candidate
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Email = model.Email,
                ResumeURL = model.ResumeURL

            };

            var candidate = await _candidateRepository.AddAsync(candidateEntity);
            return candidate.Id;
        }

        public async Task<List<CandidateResponseModel>> GetAllCandidates()
        {
            var candidates = await _candidateRepository.GetAllCandidates();
            var candidatesResponseModel = new List<CandidateResponseModel>();
            foreach (var candidate in candidates)
            {
                candidatesResponseModel.Add(new CandidateResponseModel()
                {
                    Id = candidate.Id,
                    FirstName = candidate.FirstName,
                    MiddleName = candidate.MiddleName,
                    LastName = candidate.LastName,
                    Email = candidate.Email, 
                    ResumeURL = candidate.ResumeURL
                });
            }
            return candidatesResponseModel;
        }




        public async Task<CandidateResponseModel> GetCandidateById(int id)
        {
            var candidate = await _candidateRepository.GetCandidateById(id);
            if (candidate == null)
            {
                return null;
            }
            var candidateResponseModel = new CandidateResponseModel
            {
                Id = candidate.Id,
                FirstName = candidate.FirstName,
                MiddleName = candidate.MiddleName,
                LastName = candidate.LastName,
                Email = candidate.Email,
                ResumeURL = candidate.ResumeURL
            };
            return candidateResponseModel;
        }


    }
}



/*
        private readonly ICandidateRepository _candidateSRepository;

        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateSRepository = candidateRepository;
        }
        public List<CandidateResponseModel> GetAllCandidates()
        {
            var candidates = _candidateSRepository.GetAllCandidates();
            var candidateResponseModel = new List<CandidateResponseModel>();
            foreach (var candidate in candidates)
            {
                candidateResponseModel.Add(new CandidateResponseModel()
                {

                    Id = candidate.Id,
                    FirstName = candidate.FirstName,
                    MiddleName = candidate.MiddleName,
                    LastName = candidate.LastName,
                    Email = candidate.Email,
                    ResumeURL = candidate.ResumeURL,
                    CreateOn = candidate.CreateOn,
                });
            }
            return candidateResponseModel;
        }

        public CandidateResponseModel GetCandidateById(int id)
        {
            var candidate = _candidateSRepository.GetCandidateById(id);
            var candidateResponseModel = new CandidateResponseModel()
            {
                Id = candidate.Id,
                FirstName = candidate.FirstName,
                MiddleName = candidate.MiddleName,
                LastName = candidate.LastName,
                Email = candidate.Email,
                ResumeURL = candidate.ResumeURL,
                CreateOn = candidate.CreateOn,
            };
            return candidateResponseModel;

        }
 */