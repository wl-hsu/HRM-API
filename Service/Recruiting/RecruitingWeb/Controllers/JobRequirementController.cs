using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class JobRequirementController : Controller
    {
        private IJobService _jobService;

        public JobRequirementController(IJobService jobService)
        {
            _jobService = jobService;

        }

    }
}
