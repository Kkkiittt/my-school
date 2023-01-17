using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Comments;
using My_School.Domain.Entities.Comments;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Comments;

namespace MySchool.DataAccess.Repositories.Comments;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
	public CommentRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
	public async override Task<Comment?> FindByIdAsync(long id)
	{
		var comment = await base.FindByIdAsync(id);
		await _dbContext.Entry(comment).Reference(x => x.Student).LoadAsync();
		await _dbContext.Entry(comment).Reference(x => x.Article).LoadAsync();

		return comment;
	}
	public override async Task<Comment?> FirstOrDefaultAsync(Expression<Func<Comment, bool>> expression)
	{
		var comment = await base.FirstOrDefaultAsync(expression);
		await _dbContext.Entry(comment).Reference(x => x.Student).LoadAsync();
		await _dbContext.Entry(comment).Reference(x => x.Article).LoadAsync();

		return comment;
	}
	public override IQueryable<Comment> GetAll()
	{
		return base.GetAll().Include(x => x.Student).Include(x => x.Article);
	}
	public override IQueryable<Comment> Where(Expression<Func<Comment, bool>> expression)
	{
		return base.Where(expression).Include(x => x.Student).Include(x => x.Article);
	}
}
