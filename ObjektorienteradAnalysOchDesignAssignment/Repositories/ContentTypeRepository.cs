using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Context;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Repositories
{
    public class ContentTypeRepository
    {
        private readonly DataContext _dataContext;

        public ContentTypeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ContentTypeEntity> GetOneAsync(int Id)
        {
            return await _dataContext.ContentType.FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}

