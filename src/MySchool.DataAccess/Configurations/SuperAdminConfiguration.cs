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
			Password = "a7029aeb06f181e9116ea8af2b80d7b3ffec0691f44aa58967d7f6ba5adc95d9",
			Phone = "998930090415",
			PhoneVerified = true,
			Role = Role.Admin,
			Image = "",
			Acted = default
		}
		);
	}
}
