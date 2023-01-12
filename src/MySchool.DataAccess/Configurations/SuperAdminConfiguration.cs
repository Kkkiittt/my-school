using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using My_School.Domain.Entities.Employees;
using My_School.Domain.Enums;

namespace MySchool.DataAccess.Configurations;

public class SuperAdminConfiguration : IEntityTypeConfiguration<Employee>
{
	public void Configure(EntityTypeBuilder<Employee> builder)
	{
		_ = builder.HasData(new Employee()
		{
			Id = 1,
			Name = "Admin",
			Password = "mk5/RJY1Pg65Z4MqpNnG5rCDUDGtjM2P42MlohbRcEs=",
			Email = "khamidov357@gmail.com",
			EmailVerified = true,
			Role = Role.Admin,
			Image = "",
			Acted = DateTime.MinValue
		}
		);
	}
}
