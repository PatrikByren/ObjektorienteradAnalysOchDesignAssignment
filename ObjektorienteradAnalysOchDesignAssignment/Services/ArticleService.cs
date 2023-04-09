
using Microsoft.AspNetCore.Mvc;
using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Factories;
using ObjektorienteradAnalysOchDesignAssignment.Models.Entity;
using ObjektorienteradAnalysOchDesignAssignment.Repositories;
using System.Collections.Generic;

namespace ObjektorienteradAnalysOchDesignAssignment.Services;

public class ArticleService
{
    private readonly ArticleRepository _articleRepo;
    private readonly TagRepository _tagRepo;
    private readonly AuthorRepository _authorRepo;
    private readonly ContentTypeRepository _contentTypeRepo;

    public ArticleService(ArticleRepository repo, TagRepository tagRepo, AuthorRepository authorRepo, ContentTypeRepository contentTypeRepo)
    {
        _articleRepo = repo;
        _tagRepo = tagRepo;
        _authorRepo = authorRepo;
        _contentTypeRepo = contentTypeRepo;
    }

    public async Task<ArticleRespons> CreateAsync(ArticleEntity req)
    {
        req.Tag = await _tagRepo.GetOneAsync(req.TagId);
        req.Author = await _authorRepo.GetOneAsync(req.AuthorId);
        req.ContentType = await _contentTypeRepo.GetOneAsync(req.ContentTypeId);
        var res = await _articleRepo.SaveAsync(req);

        return res;
    }
    public async Task<IActionResult> UpdateAsync(int id, ArticleRequest articleToUpdate) 
    {
        var article = await _articleRepo.GetAsync(id);
        if (article != null)
        {
            article.Title = articleToUpdate.Title;
            article.Content = articleToUpdate.Content;
            article.PublishDate = articleToUpdate.PublishDate;
            article.ContentTypeId = articleToUpdate.ContentTypeId;
            article.AuthorId = articleToUpdate.AuthorId;
            article.TagId = articleToUpdate.TagId;
            return await _articleRepo.UpdateAsync(article);
        }
        else { }
        return null!;
    }
    public async Task<IActionResult> DeleteAsync(int id) 
    {
        return await _articleRepo.DeleteAsync(await _articleRepo.GetAsync(id));
    }
    public async Task<ArticleRespons> GetAsync(int id)
    {
        return await _articleRepo.GetAsync(id);
    }
    public async Task<IEnumerable<ArticleRespons>> GetAllAsync()
    {
        var list = ListFactory.CreateList();
        var result = await _articleRepo.GetAllAsync();
        foreach (var item in result)
            list.Add(ArticleFactory.CreateArticleRespons(item));
        return list;
    }
    public async Task<IEnumerable<ArticleRespons>> GetAllAsync(int id)
    {
        var list = ListFactory.CreateList();
        var result = await _articleRepo.GetAllAsync(id);
        foreach (var item in result)
            list.Add(ArticleFactory.CreateArticleRespons(item));
        return list;
    }
}
