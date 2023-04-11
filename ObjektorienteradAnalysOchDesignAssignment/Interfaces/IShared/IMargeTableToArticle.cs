using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Interfaces.IShared;

public interface IMargeTableToArticle
{
    public ICollection<ArticleEntity> Articles { get; set; }
}
