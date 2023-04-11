using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using System.Collections.ObjectModel;

namespace ObjektorienteradAnalysOchDesignAssignment.Interfaces.IArticle
{
    public interface IArticleRespons : IBaseArticle
    {
        public ObservableCollection<AuthorRespons> Authors { get; set; }
        public string Tag { get; set; }
        public string ContentType { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
