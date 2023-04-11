using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Interfaces.IAuthorArticleRow
{
    public interface IAuthorArticleRowEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int ArticleId { get; set; }
        public AuthorEntity Author { get; set; }
        public ArticleEntity Article { get; set; }  
    }
}
