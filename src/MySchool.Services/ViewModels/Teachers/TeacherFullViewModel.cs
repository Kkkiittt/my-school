using My_School.Domain.Entities.Articles;
using My_School.Domain.Enums;
using MySchool.Services.ViewModels.Articles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.ViewModels.Teachers
{
    public class TeacherFullViewModel
    {
       
        public string Name { get; set; } = string.Empty;

        public string Phone  { get; set; } = string.Empty;

        public Role Role { get; set; }

        public List<ArticleShortViewModel> Articles { get; set; } = new();

    }
}
