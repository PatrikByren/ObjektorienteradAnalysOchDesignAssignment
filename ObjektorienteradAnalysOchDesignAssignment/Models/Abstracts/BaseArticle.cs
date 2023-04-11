using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IArticle;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Abstracts
{
    public abstract class BaseArticle : IBaseArticle
    {
        public virtual string Content { get; set; } = null!;
        public virtual string Title { get; set; } = null!; 
        
    }
}
