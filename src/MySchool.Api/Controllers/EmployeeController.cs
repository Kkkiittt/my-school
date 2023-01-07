using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySchool.Services.Dtos.Employees;
using MySchool.Services.Interfaces;

namespace My_School.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("EmployeeRegister")]
        public async Task<IActionResult> RegisterAsync([FromForm] EmployeeRegisterDto dto)
        {
            return Ok(await _employeeService.RegisterAsync(dto));
        }

        [HttpPost("EmployeeLogin")]
        public async Task<IActionResult> LoginAsync([FromForm] EmployeeLoginDto dto)
        {
            return Ok(await _employeeService.LoginAsync(dto));
        }

        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult> DeleteByIdAsync(long id)
        {
            return Ok(await _employeeService.DeleteByIdAsync(id));
        }


        [HttpPut("MakeAuthor")]
        public async Task<IActionResult> MakeAuthorAsync(long id)
        {
            return Ok(await _employeeService.MakeAuthor(id));
        }



    }
}
