using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using My_School.Domain.Entities.Students;
using My_School.Domain.Models.Employees;
using MySchool.Services.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.Service.Common
{
	public class AuthManager : IAuthManager
	{
		private readonly IConfiguration _config;

		public AuthManager(IConfiguration configuration)
		{
			_config = configuration.GetSection("Jwt");
		}

		public string GenerateToken(Student student)
		{
			var claims = new[]
			{
				new Claim("Id", student.Id.ToString())
			};

			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecretKey"]));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

			var tokenDescriptor = new JwtSecurityToken(_config["Issuer"], _config["Audience"], claims,
				expires: DateTime.Now.AddYears(int.Parse(_config["Lifetime"])),
				signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

		}

		public string GenerateToken(Employee employee)
		{
			var claims = new[]
			{
				new Claim("Id", employee.Id.ToString()),
				new Claim(ClaimTypes.Role, employee.Role.ToString()),
			};

			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecretKey"]));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

			var tokenDescriptor = new JwtSecurityToken(_config["Issuer"], _config["Audience"], claims,
				expires: DateTime.Now.AddMonths(int.Parse(_config["Lifetime"])),
				signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
		}
	}
}
