using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;
using System.ComponentModel.DataAnnotations;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entities
{
    public class AuthorArticleRowEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int ArticleId { get; set; }
        public AuthorEntity Author { get; set; } = null!;
        public ArticleEntity Article { get; set; } = null!;
        /*public static implicit operator AuthorRespons(AuthorArticleRowEntity authorArticle)
        {
            var res = AuthorFactory.CreateAuthorRespons();
            res.Name = authorArticle.Author.Name;
            return res;
        }*/
    }

}
