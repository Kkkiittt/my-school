using Microsoft.EntityFrameworkCore;
using My_School.DataAccess.Configurations;
using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Charters;
using My_School.Domain.Entities.Comments;
using My_School.Domain.Entities.Students;
using My_School.Domain.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.DataAccess.DbContexts
{
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
            modelBuilder.ApplyConfiguration(new SuperAdminConfiguration());
        }
    }
}
