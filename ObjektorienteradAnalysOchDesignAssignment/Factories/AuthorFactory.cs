using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Factories
{
    public class AuthorFactory
    {
        public static AuthorRespons CreateAuthorRespons() => new();
       /* public static AuthorRespons CreateAuthorRespons(string name) => new() 
        { 
            Name= name
        };*/
    }
}
