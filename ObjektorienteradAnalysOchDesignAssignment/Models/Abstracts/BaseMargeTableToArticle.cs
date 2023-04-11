using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IShared;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Abstracts
{
    public abstract class BaseMargeTableToArticle : IMargeTableWhitNameToArticle
    {
        public ICollection<ArticleEntity>? Articles { get; set; }
        public string Name { get; set; } = null!;
        public int Id { get; set; }
    }
}
