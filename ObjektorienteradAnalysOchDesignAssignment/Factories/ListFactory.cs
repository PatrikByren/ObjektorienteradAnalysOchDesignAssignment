using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;

namespace ObjektorienteradAnalysOchDesignAssignment.Factories
{
    public class ListFactory
    {
        public static List<ArticleRespons> CreateList() => new();
        public static List<AuthorArticleRowEntity> CreateAuthorArticleRowList() => new();
    }
}
