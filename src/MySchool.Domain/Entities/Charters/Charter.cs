using My_School.Domain.Entities.Students;
using My_School.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_School.Domain.Entities.Charters
{
    public class Charter : Auditable
    {
        public long StudentId { get; set; } 
        public virtual Student Student { get; set; }

        public string Image { get; set; } = string.Empty;

    }
}
