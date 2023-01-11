using My_School.Domain.Common;
using My_School.Domain.Entities.Students;

namespace My_School.Domain.Entities.Charters;

public class Charter : Auditable
{
	public long StudentId { get; set; }
	public virtual Student Student { get; set; }

	public string Image { get; set; } = string.Empty;

}
