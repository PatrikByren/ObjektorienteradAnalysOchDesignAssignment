using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Context;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Repositories
{
    public class TagRepository
    {
        private readonly DataContext _dataContext;

        public TagRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<TagEntity> GetOneAsync(int Id)
        {
            return await _dataContext.Tags.FirstOrDefaultAsync(x => x.Id == Id) ?? null!; ;
        }
    }
}
