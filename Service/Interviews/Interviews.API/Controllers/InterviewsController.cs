using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Interviews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewsController : ControllerBase
    {

        private readonly IInterviewService _interviewService;
        public InterviewsController(IInterviewService interviewService)
        {
            _interviewService = interviewService;
        }

        // http:localhost/api/jobs
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetAllInterviews()
        {
            var interviews = await _interviewService.GetAllInterviews();
            // return JSON data and http status code
            // serialization C# object into JSON Objects using system.Text.Json
            if (!interviews.Any())
            {
                // not job exist
                return NotFound(new { error = "no open interviews found, please try later." });
            }
            return Ok(interviews);
        }

        // http:localhost/api/jobs/4
        [HttpGet]
        [Route("{id:int}", Name = "Get_InterviewServicDetails")]
        public async Task<IActionResult> GetInterviewDetails(int id)
        {


            var interview = await _interviewService.GetInterviewById(id);
            if (interview == null)
            {
                return NotFound(new { errorMessage = "No Job found for this id" });
            }
            return Ok(interview);
        }


        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> Create(InterviewRequestModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var interview = await _interviewService.AddInterview(model);
            return CreatedAtAction("GetInterviewDetails", new { controller = "Interviews", id = interview }, "Interview Created");
        }

    }
}

