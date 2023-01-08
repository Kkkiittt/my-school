using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using My_School.Domain.Enums;
using My_School.Domain.Models.Employees;

namespace My_School.DataAccess.Configurations;

public class SuperAdminConfiguration : IEntityTypeConfiguration<Employee>
{
	public void Configure(EntityTypeBuilder<Employee> builder)
	{
		_ = builder.HasData(new Employee()
		{
			Id = 1,
			Name = "Admin",
			Password = "mk5/RJY1Pg65Z4MqpNnG5rCDUDGtjM2P42MlohbRcEs=",
			Phone = "khamidov357@gmail.com",
			PhoneVerified = true,
			Role = Role.Admin,
			Image = "",
			Acted = DateTime.MinValue
		}
		);
	}
}
