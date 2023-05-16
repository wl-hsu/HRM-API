using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers
{
    public class SubmissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
