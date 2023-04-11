using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Interfaces.IArticle
{
    public interface IArticleEntity : IBaseArticle
    {
        public int Id { get; set; }
        public int ContentTypeId { get; set; }
        public int? TagId { get; set; }
        public ContentTypeEntity ContentType { get; set; }
        public ICollection<AuthorArticleRowEntity> AuthorRow { get; set; }
        public TagEntity Tag { get; set; }

        public DateTime PublishDate { get; set; }

    }
}
