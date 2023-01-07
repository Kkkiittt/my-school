using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces;

namespace My_School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost(" Employee Register")]

        public async Task<IActionResult> RegisterAsync([FromForm] EmployeeRegisterDto dto)
        {
            return Ok(await _employeeService.RegisterAsync(dto));
        }
    }
}
