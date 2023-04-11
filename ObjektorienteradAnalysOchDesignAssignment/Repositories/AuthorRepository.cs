using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Context;
using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Models;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Repositories
{
    public class AuthorRepository
    {
        private readonly DataContext _dataContext;

        public AuthorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ICollection<AuthorArticleRowEntity>> GetOneAsync(ArticleRequest req)
        {
            var list = ListFactory.CreateAuthorArticleRowList();
            
            foreach (var item in req.Authors)
            {
                var resp = AuthorArticleRowFactory.CreateAuthorArticleRowEntity();
                var data = await _dataContext.Author.FirstOrDefaultAsync(x => x.Id == item.id);
                resp.Author = data!;   
                list.Add(resp);
                
            }; 
            return list; 
        }
        public async Task<IEnumerable<AuthorEntity>> GetAllAsync()
        {
            return await _dataContext.Author.ToListAsync();
        }
    }
}
