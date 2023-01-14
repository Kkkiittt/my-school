using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Entities.Comments;
using My_School.Domain.Entities.Employees;
using My_School.Domain.Entities.Students;
using MySchool.DataAccess.Configurations;

namespace MySchool.DataAccess.DbContexts;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options)
	: base(options)
	{
	}

	public virtual DbSet<Employee> Employees { get; set; } = default!;

	public virtual DbSet<Charter> Charters { get; set; } = default!;

	public virtual DbSet<Student> Students { get; set; } = default!;

	public virtual DbSet<Comment> Comments { get; set; } = default!;

	public virtual DbSet<Article> Articles { get; set; } = default!;

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		_ = modelBuilder.ApplyConfiguration(new SuperAdminConfiguration());
	}
}
