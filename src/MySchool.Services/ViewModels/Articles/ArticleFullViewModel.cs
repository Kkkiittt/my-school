using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.ViewModels.Articles
{
    public class ArticleFullViewModel
    {
        public string HTML { get; set; } = string.Empty;

        public string AuthorName { get; set; } = string.Empty; 

        public string AuthorImage { get; set; } = string.Empty; 

        public long Views { get; set; } 

        public string Title { get; set; } = string.Empty; 

        public string Comments { get; set; } = string.Empty;

        public DateTime Created { get; set; }
    }
}
