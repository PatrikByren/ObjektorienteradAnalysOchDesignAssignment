using ObjektorienteradAnalysOchDesignAssignment.Factories;

namespace ObjektorienteradAnalysOchDesignAssignment.DTOs;

public class ArticleRespons
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime PublishDate { get; set; }
    public string Author { get; set; } = null!;
    public string Tag { get; set; } = null!;
    public string ContentType { get; set; } = null!;

}
