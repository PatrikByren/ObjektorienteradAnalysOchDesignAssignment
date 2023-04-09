using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

public class ArticleEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime PublishDate { get; set; }
    public int ContentTypeId { get; set; }
    public int AuthorId { get; set; }
    public int TagId { get; set; }
    public ContentTypeEntity? ContentType { get; set; }
    public AuthorEntity? Author { get; set; } 
    public TagEntity? Tag { get; set; }
    public static implicit operator ArticleRespons(ArticleEntity article)
    {
        var res = ArticleFactory.CreateArticleRespons();
        res.Title = article.Title;
        res.Content = article.Content;
        res.PublishDate = article.PublishDate;
        res.Tag = article.Tag!.Name;
        res.Author = article.Author!.Name;
        res.ContentType = article.ContentType!.Name;

        return res;
    }
}
