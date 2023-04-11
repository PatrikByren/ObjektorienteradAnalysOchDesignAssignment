using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;

namespace ObjektorienteradAnalysOchDesignAssignment.DTOs
{
    public class AuthorRespons
    {
        public string Name { get; set; } = null!;
    }


    /*public static implicit operator AuthorArticleRowEntity (AuthorRespons author)
    {
        var res = AuthorArticleRowResponsFactory.CreateAuthorArticleRowRespons();
        foreach(var item in author)
        res.Authors = author.Name;
        return res;
    }*/
    
}
