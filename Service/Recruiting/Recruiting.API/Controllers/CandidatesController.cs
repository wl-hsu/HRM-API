using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Recruiting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private readonly ICandidateService _candidateService;

        public CandidatesController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }


        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetAllCandidatess()
        {
            var candidates = await _candidateService.GetAllCandidates();

            if (!candidates.Any())
            {
                // not job exist
                return NotFound(new { error = "no open Candidates found, please try later." });
            }
            return Ok(candidates);
        }


        // http:localhost/api/jobs/4
        [HttpGet]
        [Route("{id:int}", Name = "GetCandidateDetails")]
        public async Task<IActionResult> GetJobDetails(int id)
        {


            var candidate = await _candidateService.GetCandidateById(id);
            if (candidate == null)
            {
                return NotFound(new { errorMessage = "No candidate found for this id" });
            }
            return Ok(candidate);
        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create(CandidateRequestModel model)
        {
            if (!ModelState.IsValid)
                // 400 status code
                return BadRequest();

            var candidate = await _candidateService.AddCandidate(model);
            return CreatedAtAction
                ("GetJobDetails", new { controller = "Candidates", id = candidate }, "Candidate Created");
        }



    }
}
