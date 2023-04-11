using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IAuthor;
using ObjektorienteradAnalysOchDesignAssignment.Models.Abstracts;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entity
{
    public class AuthorEntity : IAuthorEntity
    {
        public ICollection<AuthorArticleRowEntity>? Articles { get; set; }
        public string Name { get; set; } = null!;
        public int Id { get; set; }
    }
}
