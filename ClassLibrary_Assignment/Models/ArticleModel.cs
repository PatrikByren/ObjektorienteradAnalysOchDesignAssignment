/*using ClassLibrary_Assignment.Factories;
using ClassLibrary_Assignment.Models.Entities;

namespace ClassLibrary_Assignment.Models;
public class ArticleModel
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime PublishDate { get; set; } = DateTime.Now;
    public ContentTypeModel ContentType { get; set; } = null!;
    public ICollection<AuthorModel> Author { get; set; } = null!;
    public ICollection<TagsModel> Tags { get; set; } = null!;

    public static implicit operator ArticleEntity(ArticleModel article)
    {
        var userEntity = ArticleEntityFactory.CreateArticleEntity();
        userEntity.Title = article.Title;
        userEntity.Content = article.Content;
        userEntity.PublishDate = article.PublishDate;
        
        return userEntity;
    }

}*/
