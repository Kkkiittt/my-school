using My_School.Domain.Entities.Comments;

using MySchool.DataAccess.DbContexts;
using MySchool.DataAccess.Interfaces.Comments;

namespace MySchool.DataAccess.Repositories.Comments;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
	public CommentRepository(AppDbContext dbContext) : base(dbContext)
	{
	}
}
