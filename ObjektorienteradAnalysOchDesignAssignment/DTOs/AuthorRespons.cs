using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IAuthor;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;

namespace ObjektorienteradAnalysOchDesignAssignment.DTOs
{
    public class AuthorRespons : IAuthorRespons
    {
        public string Name { get; set; } = null!;
    }
}
