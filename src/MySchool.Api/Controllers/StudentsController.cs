﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySchool.Services.Dtos.Students;
using MySchool.Services.Interfaces;

namespace My_School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpPost("Student Register")]
        public async Task<IActionResult> RegisterAsync([FromForm] StudentRegisterDto dto)
        {
            return Ok(await _studentService.RegisterAsync(dto));
        }
    }
}
