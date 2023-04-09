using ClassLibrary_Assignment.Interfaces;
using ClassLibrary_Assignment.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Assignment.Models
{
    public abstract class ArticleBase : IArticleBase
    {
        public int ContentTypeId {get; set; }
        public string Title {get; set; } 
        public string Content {get; set; }
        public DateTime PublishDate {get; set; }

    }
}
