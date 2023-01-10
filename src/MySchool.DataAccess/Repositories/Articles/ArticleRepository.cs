using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Articles;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Articles;

namespace MySchool.DataAccess.Repositories.Articles;

public class ArticleRepository : GenericRepository<Article>, IArticleRepository
{
	public ArticleRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
	public override IQueryable<Article> GetAll()
	{
		return base.GetAll().Include(a => a.Employee);
	}
	public override IQueryable<Article> Where(Expression<Func<Article, bool>> expression)
	{
		return base.Where(expression).Include(a => a.Employee);
	}
}
