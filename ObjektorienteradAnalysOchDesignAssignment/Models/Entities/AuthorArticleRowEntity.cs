using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IAuthorArticleRow;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;
using System.ComponentModel.DataAnnotations;

namespace ObjektorienteradAnalysOchDesignAssignment.Models.Entities;

public class AuthorArticleRowEntity : IAuthorArticleRowEntity
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public int ArticleId { get; set; }
    public AuthorEntity Author { get; set; } = null!;
    public ArticleEntity Article { get; set; } = null!;
}
