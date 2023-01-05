using My_School.Domain.Entities.Articles;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Articles;

namespace MySchool.DataAccess.Repositories.Articles;

public class ArticleRepository : GenericRepository<Article>, IArticleRepository
{
	public ArticleRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
}
