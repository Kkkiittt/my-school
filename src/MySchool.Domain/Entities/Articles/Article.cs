using My_School.Domain.Models.Common;
using My_School.Domain.Models.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_School.Domain.Entities.Articles
{
    public class Article : Auditable
    {
        public string Title { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public string HTML { get; set; } = string.Empty;

        public long Views { get; set; } 

        public long EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } 
    }
}
