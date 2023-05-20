using ApplicationCore.Model;
using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnBoarding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {

        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllEmployees();
            // return JSON data and http status code
            // serialization C# object into JSON Objects using system.Text.Json
            if (!employees.Any())
            {
                // not job exist
                return NotFound(new { error = "no open jobs found, please try later." });
            }
            return Ok(employees);
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetEmployeeDetails")]
        public async Task<IActionResult> GetEmployeeDetails(int id)
        {


            var employee = await _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound(new { errorMessage = "No Employee found for this id" });
            }
            return Ok(employee);
        }



        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create(EmployeeRequestModel model)
        {
            if (!ModelState.IsValid)
                // 400 status code
                return BadRequest();

            var employee = await _employeeService.AddEmployee(model);
            return CreatedAtAction
                ("GetEmployeeDetails", new { controller = "Employees", id = employee }, "Employee Created");
        }



    }
}
