using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Factories;

public class ArticleFactory
{
    public static ArticleEntity CreateArticleEntity() => new ArticleEntity();
    public static ArticleRequest CreateArticleRequest() => new ArticleRequest();
    public static ArticleRespons CreateArticleRespons() => new ArticleRespons();
    public static ArticleRespons CreateArticleRespons(ArticleEntity entity) { return new ArticleRespons()
        {                 
            Title = entity.Title,
            Content = entity.Content,
            PublishDate = entity.PublishDate,
            Tag = entity.Tag!.Name,
            Author = entity.Author!.Name,
            ContentType = entity.ContentType!.Name
        }; 
    }
}
