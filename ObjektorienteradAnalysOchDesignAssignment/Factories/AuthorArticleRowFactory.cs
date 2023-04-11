using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Factories
{
    public class AuthorArticleRowFactory
    {
        public static AuthorArticleRowRespons CreateAuthorArticleRowRespons() => new();
        public static AuthorArticleRowEntity CreateAuthorArticleRowEntity() => new();
        
    }
}
