using ApplicationCore.Contracts.Services;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class CandidateController : Controller
    {

        private ICandidateService _CandidateService;

        public CandidateController(ICandidateService CandidateService)
        {
            _CandidateService = CandidateService;

        }
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Showing Candidates";
            var candidates = _CandidateService.GetAllCandidates();
            return View(candidates);
        }
    }
}
