using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Recruiting.API.Controllers
{

    // touring
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        // add reference for application and infra projects
        // copy all the registeration including Dbcontext into API project program.cs
        // copy the connection string from MVC app.setting to api app.setting
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }


        // http:localhost/api/jobs
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _jobService.GetAllJobs();
            // return JSON data and http status code
            // serialization C# object into JSON Objects using system.Text.Json
            if (!jobs.Any())
            {
                // not job exist
                return NotFound(new { error = "no open jobs found, please try later." });
            }
            return Ok(jobs);
        }




        // http:localhost/api/jobs/4
        [HttpGet]
        [Route("{id:int}", Name = "GetJobDetails")]
        public async Task<IActionResult> GetJobDetails(int id)
        {


            var job = await _jobService.GetJobsById(id);
            if (job == null)
            {
                return NotFound(new { errorMessage = "No Job found for this id" });
            }
            return Ok(job);
        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create(JobRequestModel model)
        {
            if (!ModelState.IsValid)
                // 400 status code
                return BadRequest();

            var job = await _jobService.AddJob(model);
            return CreatedAtAction
                ("GetJobDetails", new { controller = "Jobs", id = job }, "Job Created");
        }


        [Route("{Keyword}")]
        [HttpGet]
        public async Task<IActionResult> SearchByTitle(string Keyword)
        {
            var jobs = await _jobService.GetJobsByKeyword(Keyword);
            if (!jobs.Any())
            {
                return NotFound();
            }
            return Ok(jobs);
        }



        // close job by modify status
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJobById(JobRequestModel model, int id)
        {
            if (!ModelState.IsValid || id <= 0)
            {
                return BadRequest();
            }
            var job = await _jobService.GetJobsById(id);
            if (job == null)
            {
                return NotFound();
            }
            var temp = await _jobService.UpdateJobById(model, id);
            return Ok();
        }


    }
}
