using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Models.Abstracts;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entity
{
    [Index(nameof(Name), IsUnique = true)]
    public class ContentTypeEntity : BaseMargeTableToArticle
    {
    }
}
