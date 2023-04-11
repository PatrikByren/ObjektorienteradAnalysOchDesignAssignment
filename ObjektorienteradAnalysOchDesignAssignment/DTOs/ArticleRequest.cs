
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IArticle;
using ObjektorienteradAnalysOchDesignAssignment.Models;
using ObjektorienteradAnalysOchDesignAssignment.Models.Abstracts;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;
using System.ComponentModel.DataAnnotations;

namespace ObjektorienteradAnalysOchDesignAssignment.DTOs
{
    public class ArticleRequest : BaseArticle, IArticleRequest
    {
        [Required]
        public int ContentTypeId { get; set; }
        [Required]
        public ICollection<AuthorModel> Authors { get; set; } = null!;
        [Required]
        public int TagId { get; set; }
        [Required]
        public override string Title { get; set; } = null!;
        [Required]
        public override string Content { get; set; } = null!;



        public static implicit operator ArticleEntity(ArticleRequest article)
        {

            var articleEntity = ArticleFactory.CreateArticleEntity();

            articleEntity.Title = article.Title;
            articleEntity.Content = article.Content;
            articleEntity.PublishDate = DateTime.Now;
            articleEntity.ContentTypeId = article.ContentTypeId;
            articleEntity.TagId = article.TagId;
            articleEntity.Id = articleEntity.Id;


            return articleEntity;


        }



    }

}
