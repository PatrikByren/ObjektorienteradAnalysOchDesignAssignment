using ObjektorienteradAnalysOchDesignAssignment.Factories;
using System.Collections.ObjectModel;

namespace ObjektorienteradAnalysOchDesignAssignment.DTOs;

public class ArticleRespons
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime PublishDate { get; set; }
    public ObservableCollection<AuthorRespons> Authors { get; set; } = new ObservableCollection<AuthorRespons>();
    public string Tag { get; set; } = null!;
    public string ContentType { get; set; } = null!;

}
