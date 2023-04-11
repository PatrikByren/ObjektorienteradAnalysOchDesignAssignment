using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ObjektorienteradAnalysOchDesignAssignment.Context;
using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Models;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entities;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;

namespace ObjektorienteradAnalysOchDesignAssignment.Repositories
{
    public class AuthorArticleRowRepository
    {
        private readonly DataContext _dataContext;

        public AuthorArticleRowRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ArticleEntity> SaveAsync(ArticleEntity entity, ArticleRequest req)
        {
            try
            {
                var row = AuthorArticleRowFactory.CreateAuthorArticleRowEntity();
                
                foreach (var item in req.Authors)
                {
                    
                    row.AuthorId = item.Id;
                    row.ArticleId = entity.Id;
                    _dataContext.AuthorArticleRow.Add(row); 
                    await _dataContext.SaveChangesAsync();
                    entity.AuthorRow.Add(row);
                }
                return entity;
            }
            catch { }
            return null!;
        }
        public async Task<IActionResult> UpdateAsync(ArticleEntity entity, ICollection<AuthorModel> model)
        {
            try
            {
                
                foreach(var item in entity.AuthorRow)
                {
                    _dataContext.AuthorArticleRow.Remove(item);
                    
                }
                foreach (var authorModel in model)
                {
                    var row = AuthorArticleRowFactory.CreateAuthorArticleRowEntity();
                    row.AuthorId = authorModel.Id;
                    row.ArticleId = entity.Id;
                    _dataContext.AuthorArticleRow.Add(row);
                }

                await _dataContext.SaveChangesAsync();
                return StatusFactory.CreateOkResult();
            }
            
            catch { }
            return null!;
        }
    }
}
