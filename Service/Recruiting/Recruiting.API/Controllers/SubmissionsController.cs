using ApplicationCore.Contracts.Services;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Models;
using ApplicationCore.Entities;

namespace Recruiting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionsController : ControllerBase
    {
        private readonly ISubmissionService _submissionService;

        public SubmissionsController(ISubmissionService iSubmissionService)
        {
            _submissionService = iSubmissionService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllSubmissions()
        {
            var submissions = await _submissionService.GetAllSubmissions();
            // return JSON data and http status code
            // serialization C# object into JSON Objects using system.Text.Json
            if (!submissions.Any())
            {
                // not submissions exist
                return NotFound(new { error = "no open submissions found, please try later." });
            }
            return Ok(submissions);
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetSubmissionById")]
        public async Task<IActionResult> GetSubmissionById(int id)
        {
            var submission = await _submissionService.GetSubmissionById(id);
            if (submission == null)
            {
                return NotFound();
            }
            return Ok(submission);
        }

        // http:localhost/api/jobs/4
        [HttpGet]
        [Route("candidate/{id:int}")]
        public async Task<IActionResult> GetSubmissionsByCandidateId(int id)
        {


            var submission = await _submissionService.GetSubmissionsByCandidateId(id);
            if (submission == null)
            {
                return NotFound(new { errorMessage = "No submission found for this id" });
            }
            return Ok(submission);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create(SubmissionRequestModel model)
        {
            if (!ModelState.IsValid)
                // 400 status code
                return BadRequest();

            var submission = await _submissionService.AddSubmission(model);
            return CreatedAtAction
                ("GetSubmissionById", new { controller = "Submissions", id = submission }, "Submission Created");
        }

    }
}
