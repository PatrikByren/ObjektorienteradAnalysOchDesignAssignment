using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entity
{
    public class AuthorEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<AuthorArticleRowEntity>? Articles { get; set; }
    }
}
