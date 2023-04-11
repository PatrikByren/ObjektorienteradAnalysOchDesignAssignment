using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Interfaces.IArticle;
using ObjektorienteradAnalysOchDesignAssignment.Models.Abstracts;
using System.Collections.ObjectModel;

namespace ObjektorienteradAnalysOchDesignAssignment.DTOs;

public class ArticleRespons : BaseArticle, IArticleRespons
{
    public ObservableCollection<AuthorRespons> Authors { get; set; } = new ObservableCollection<AuthorRespons>();
    public string Tag { get; set; } = null!;
    public string ContentType { get; set; } = null!;
    public DateTime PublishDate { get; set; }

}
