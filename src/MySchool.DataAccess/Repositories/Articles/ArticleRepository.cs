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
	public async override Task<Article?> FindByIdAsync(long id)
	{
		var article = await base.FindByIdAsync(id);
		await _dbContext.Entry(article).Reference(x => x.Employee).LoadAsync();
		return article;
	}
	public override async Task<Article?> FirstOrDefaultAsync(Expression<Func<Article, bool>> expression)
	{
		var article = await base.FirstOrDefaultAsync(expression);
		await _dbContext.Entry(article).Reference(x => x.Employee).LoadAsync();
		return article;
	}
	public override IQueryable<Article> GetAll()
	{
		return base.GetAll().Include(x => x.Employee);
	}
	public override IQueryable<Article> Where(Expression<Func<Article, bool>> expression)
	{
		return base.Where(expression).Include(x => x.Employee);
	}
}
