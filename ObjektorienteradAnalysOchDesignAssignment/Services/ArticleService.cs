
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
    private readonly AuthorArticleRowRepository _authorArticleRowRepo;

    public ArticleService(ArticleRepository repo, TagRepository tagRepo, AuthorRepository authorRepo, ContentTypeRepository contentTypeRepo, AuthorArticleRowRepository authorArticleRowRepository)
    {
        _articleRepo = repo;
        _tagRepo = tagRepo;
        _authorRepo = authorRepo;
        _contentTypeRepo = contentTypeRepo;
        _authorArticleRowRepo = authorArticleRowRepository;
    }

    public async Task<ArticleRespons> CreateAsync(ArticleRequest req)
    {
        
        var res = await _articleRepo.SaveAsync(req);
        res.Tag = await _tagRepo.GetOneAsync(req.TagId);
        res.ContentType = await _contentTypeRepo.GetOneAsync(req.ContentTypeId);
        await _authorArticleRowRepo.SaveAsync(res, req);
        res.AuthorRow = await _authorRepo.GetOneAsync(req);

        return res;
    }
    public async Task<IActionResult> UpdateAsync(int id, ArticleRequest articleToUpdate) 
    {
        var article = await _articleRepo.GetAsync(id);
        if (article != null)
        {
            await _authorArticleRowRepo.UpdateAsync(article, articleToUpdate.Authors);

            article.Title = articleToUpdate.Title;
            article.Content = articleToUpdate.Content;
            article.ContentTypeId = articleToUpdate.ContentTypeId;
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
        {
            ArticleRespons resp = item;
            list.Add(resp);
        }

        return list;
    }
    public async Task<IEnumerable<ArticleRespons>> GetAllAsync(int id)
    {
        var list = ListFactory.CreateList();
        var result = await _articleRepo.GetAllAsync(id);
        foreach (var item in result)
        {
            ArticleRespons resp = item;
            list.Add(resp);
        }
        return list;
    }
}
