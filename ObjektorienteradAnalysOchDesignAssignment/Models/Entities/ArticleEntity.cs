using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IArticle;
using ObjektorienteradAnalysOchDesignAssignment.Models.Abstracts;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

public class ArticleEntity : BaseArticle, IArticleEntity
{
    public int Id { get; set; }
    public DateTime PublishDate { get; set; }
    public int ContentTypeId { get; set; }
    public int? TagId { get; set; }
    public ContentTypeEntity ContentType { get; set; } = null!;
    public ICollection<AuthorArticleRowEntity> AuthorRow { get; set; } = null!;
    public TagEntity? Tag { get; set; }
    public static implicit operator ArticleRespons(ArticleEntity article)
    {
        var res = ArticleFactory.CreateArticleRespons();
        res.Title = article.Title;
        res.Content = article.Content;
        res.PublishDate = article.PublishDate;
        res.Tag = article.Tag!.Name;
        res.ContentType = article.ContentType!.Name;
        foreach(var item in article.AuthorRow!)
        {
                var name = AuthorFactory.CreateAuthorRespons();
                name.Name = item.Author.Name;
                res.Authors.Add(name);
        }
        
        return res;
    }
}
