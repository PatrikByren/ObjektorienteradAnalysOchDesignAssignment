using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Context;
using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Repositories;

public class ArticleRepository
{
    private readonly DataContext _dataContext;

    public ArticleRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<ArticleEntity> SaveAsync(ArticleEntity entity)
    {
        try
        {
        _dataContext.Articles.Add(entity);
        await _dataContext.SaveChangesAsync();
        return entity;
        }
        catch { }
        return null!;
    }
    public async Task<IEnumerable<ArticleEntity>> GetAllAsync()
    {
        return await _dataContext.Articles.Include(x =>x.AuthorRow).ThenInclude(x => x.Author).Include(x => x.ContentType).Include(x => x.Tag).ToListAsync();
    }
    public async Task<IEnumerable<ArticleEntity>> GetAllAsync(int id)
    {
        return await _dataContext.Articles.Include(x => x.AuthorRow).ThenInclude(x => x.Author).Include(x => x.ContentType).Include(x => x.Tag).Where(x => x.ContentTypeId == id).ToListAsync();
    }
    public async Task<IActionResult> UpdateAsync(ArticleEntity entity)
    {
        try
        {
            _dataContext.Entry(entity).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();
            return StatusFactory.CreateOkResult();
        }
        catch { }
        return null!;
    }
    public async Task<IActionResult> DeleteAsync(ArticleEntity entity) 
    {
        try
        {
            
            if (entity != null)
            {
                _dataContext.Articles.Remove(entity);
                await _dataContext.SaveChangesAsync();
                return StatusFactory.CreateOkResult();
            }
            else
            {
                return null!;
            }
        }
        catch
        {
            return null!;
        }
    }

    public async Task<ArticleEntity> GetAsync(int id)
    {
        return await _dataContext.Articles.Include(x => x.AuthorRow).ThenInclude(x => x.Author).Include(x => x.ContentType).Include(x => x.Tag).FirstOrDefaultAsync(x => x.Id == id) ?? null!;
    }
}
