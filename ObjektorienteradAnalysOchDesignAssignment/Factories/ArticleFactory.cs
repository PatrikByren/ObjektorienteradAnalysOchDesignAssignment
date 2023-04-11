using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Factories;

public class ArticleFactory
{
    public static ArticleEntity CreateArticleEntity() => new();
    public static ArticleRequest CreateArticleRequest() => new();
    public static ArticleRespons CreateArticleRespons() => new();
}
