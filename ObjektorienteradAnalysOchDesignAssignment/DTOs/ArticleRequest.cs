
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;
using System.ComponentModel.DataAnnotations;

namespace ObjektorienteradAnalysOchDesignAssignment.DTOs
{
    public class ArticleRequest
    {
        [Required]
        public int ContentTypeId { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public int TagId { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Content { get; set; } = null!;
        public DateTime PublishDate { get; set; }


        public static implicit operator ArticleEntity(ArticleRequest article)
        {

            var articleEntity = ArticleFactory.CreateArticleEntity();

            articleEntity.Title = article.Title;
            articleEntity.Content = article.Content;
            articleEntity.PublishDate = article.PublishDate;
            articleEntity.ContentTypeId = article.ContentTypeId;
            articleEntity.AuthorId = article.AuthorId;
            articleEntity.TagId = article.TagId;
            articleEntity.Id = articleEntity.Id;


            return articleEntity;


        }



    }

}
