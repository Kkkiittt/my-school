using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using My_School.Domain.Entities.Comments;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Comments;

namespace MySchool.DataAccess.Repositories.Comments;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
	public CommentRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
	public override IQueryable<Comment> GetAll()
	{
		return base.GetAll();
		//.Include(c => c.Student).Include(c => c.Article);
	}
	public override IQueryable<Comment> Where(Expression<Func<Comment, bool>> expression)
	{
		return base.Where(expression);
		//.Include(c => c.Student).Include(c => c.Article);
	}
}
