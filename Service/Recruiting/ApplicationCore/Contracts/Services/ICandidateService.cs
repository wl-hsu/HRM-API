﻿using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface ICandidateService
    {

        Task<List<CandidateResponseModel>> GetAllCandidates();
        Task<CandidateResponseModel> GetCandidateById(int id);

        //Task<int> AddCandidate(CandidateRequestModel model);


        Task<int> AddCandidate(CandidateRequestModel model);
    }
}
