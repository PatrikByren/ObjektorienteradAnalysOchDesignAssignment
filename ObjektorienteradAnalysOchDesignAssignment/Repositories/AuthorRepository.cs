using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Context;
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

        public async Task<AuthorEntity> GetOneAsync(int Id)
        {
            return await _dataContext.Author.FirstOrDefaultAsync(x => x.Id == Id) ?? null!;
        }
    }
}
