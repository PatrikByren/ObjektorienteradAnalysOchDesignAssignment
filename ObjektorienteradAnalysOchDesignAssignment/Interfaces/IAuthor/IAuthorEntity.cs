using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IShared;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Interfaces.IAuthor
{
    public interface IAuthorEntity : IName, IId
    {
        public ICollection<AuthorArticleRowEntity>? Articles { get; set; }
    }
}
