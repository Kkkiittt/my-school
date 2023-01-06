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
        public string HTML { get; set; }

        public string AuthorName { get; set; }

        public string AuthorImage { get; set; }

        public long Views { get; set; }

        public string Title { get; set; }

        public string Comments { get; set; }

        public DateTime Created { get; set; }
    }
}
