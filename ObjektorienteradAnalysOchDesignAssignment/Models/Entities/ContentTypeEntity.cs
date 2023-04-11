using Microsoft.EntityFrameworkCore;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entity
{
    [Index(nameof(Name), IsUnique = true)]
    public class ContentTypeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<ArticleEntity>? Articles { get; set; }
    }
}
