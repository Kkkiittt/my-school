using My_School.Domain.Common;
using My_School.Domain.Entities.Articles;
using My_School.Domain.Entities.Students;

namespace My_School.Domain.Entities.Comments;

public class Comment : Auditable
{
	public string Content { get; set; } = string.Empty;

	public long ArticleId { get; set; }
	public virtual Article Article { get; set; }

	public long StudentId { get; set; }
	public virtual Student Student { get; set; }
}
