using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IAuthorArticleRow;

namespace ObjektorienteradAnalysOchDesignAssignment.DTOs
{
    public class AuthorArticleRowRespons : IAuthorArticleRowRespons
    {
        public ICollection<AuthorRespons> Authors { get; set; } = null!;
    }
}
