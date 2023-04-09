

using ClassLibrary_Assignment.Interfaces;
using System.Collections.ObjectModel;

namespace ClassLibrary_Assignment.Models.Entities;

public class ArticleEntity : ArticleBase, IArticleEntity, IArticleBase
{
    public int Id { get; set; }
    public int AuthurId { get; set; }
    public int TagId { get; set; }
    public ContentTypeEntity ContentType { get; set; }
    public ObservableCollection<AuthorEntity> Author { get; set; } 
    public ObservableCollection<TagsEntity>? Tag { get; set; } = null!;


    /*public static implicit operator ArticleRespons(ArticleEntity article)
    {
        var res = ArticleFactory.CreateArticleRespons();
        res.Title = article.Title;
        res.Content = article.Content;
        res.PublishDate = article.PublishDate;

        return res;
    }*/
}
