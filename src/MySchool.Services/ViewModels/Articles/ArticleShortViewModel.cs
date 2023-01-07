using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.ViewModels.Articles
{
    public class ArticleShortViewModel
    {
        public string Title { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public long Views { get; set; }

    }
}
