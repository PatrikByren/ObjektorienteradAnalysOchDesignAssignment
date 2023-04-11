using ObjektorienteradAnalysOchDesignAssignment.DTOs;

namespace ObjektorienteradAnalysOchDesignAssignment.Interfaces.IAuthorArticleRow
{
    public interface IAuthorArticleRowRespons
    {
        public ICollection<AuthorRespons> Authors { get; set; }
    }
}
