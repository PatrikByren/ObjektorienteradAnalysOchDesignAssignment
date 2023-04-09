using ClassLibrary_Assignment.Models;
using ClassLibrary_Assignment.Models.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Assignment.Interfaces
{
    public interface IArticleEntity
    {
        public int Id { get; set; }
        public ContentTypeEntity ContentType { get; set; }
        public ObservableCollection<AuthorEntity> Author { get; set; }
        public ObservableCollection<TagsEntity>? Tag { get; set; }
    }
}
