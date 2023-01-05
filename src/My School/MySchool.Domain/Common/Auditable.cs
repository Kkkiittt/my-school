using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_School.Domain.Models.Common
{
    public class Auditable : BaseEntity
    {
        public DateTime CreatedAt { get; set; }

    }
}
