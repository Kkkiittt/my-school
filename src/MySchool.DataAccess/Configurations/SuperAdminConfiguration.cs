using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_School.Domain.Enums;
using My_School.Domain.Models.Employees;

namespace My_School.DataAccess.Configurations
{
    public class SuperAdminConfiguration:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(new Employee()
            {
                Id = 1,
                Name="Admin",
                Password= "eab774a782c906cb9b95749769ae2b99fa1891b02837204a6a0a55bee6fe280c",
                Phone="+998930090415",
                PhoneVerified=true,
                Role=Role.Admin,
                Image=""
            }
            ) ;
        }
    }
}
