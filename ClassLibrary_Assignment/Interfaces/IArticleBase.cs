using ClassLibrary_Assignment.Models;
using ClassLibrary_Assignment.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Assignment.Interfaces
{
    public interface IArticleBase
    {
        public int ContentTypeId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
