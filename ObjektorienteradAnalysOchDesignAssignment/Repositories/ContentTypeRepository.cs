using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Context;
using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
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
            return await _dataContext.ContentType.FirstOrDefaultAsync(x => x.Id == Id) ?? null!;
        }
        public async Task<IActionResult> CreateAsync(ContentTypeEntity entity)
        {
            try
            {
            _dataContext.ContentType.Add(entity);
            await _dataContext.SaveChangesAsync();
            return StatusFactory.CreateOkResult();
            }
            catch { }
            return null!;
        }
    }
}

