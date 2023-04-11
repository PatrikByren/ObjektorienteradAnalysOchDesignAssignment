using ObjektorienteradAnalysOchDesignAssignment.Models;

namespace ObjektorienteradAnalysOchDesignAssignment.Interfaces.IArticle
{
    public interface IArticleRequest : IBaseArticle
    {   
        public int ContentTypeId { get; set; }
        public ICollection<AuthorModel> Authors { get; set; }
        public int TagId { get; set; }
    }
}
