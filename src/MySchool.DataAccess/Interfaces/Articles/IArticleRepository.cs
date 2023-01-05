using My_School.Domain.Entities.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.DataAccess.Interfaces.Articles
{
    public interface IArticleRepository : IGenericRepository<Article>
    {

    }
}
