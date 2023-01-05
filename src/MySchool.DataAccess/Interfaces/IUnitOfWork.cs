using MySchool.DataAccess.Interfaces.Articles;
using MySchool.DataAccess.Interfaces.Charters;
using MySchool.DataAccess.Interfaces.Comments;
using MySchool.DataAccess.Interfaces.Employees;
using MySchool.DataAccess.Interfaces.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        public IEmployeeRepository Employees { get; set; }

        public IArticleRepository Articles { get; set; }

        public ICharterRepository Charters { get; set; }

        public IStudentRepository Students { get; set; }

        public ICommentRepository CommentRepositories { get; set; }

        public Task<int> SaveChanges();


    }
}
