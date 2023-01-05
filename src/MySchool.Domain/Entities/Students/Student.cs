using My_School.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_School.Domain.Entities.Students
{
    public class Student : BaseEntity
    {
        public string Pin { get; set; } = string.Empty;

        public string Info { get; set; } = string.Empty ;

        public bool Studying { get; set; } = true;
    }
}
