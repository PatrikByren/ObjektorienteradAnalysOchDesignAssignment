using Azure;
using Microsoft.AspNetCore.Mvc;
using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Services;

namespace ObjektorienteradAnalysOchDesignAssignment.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArticleController : ControllerBase
{
private readonly ArticleService _articleService;

    public ArticleController(ArticleService articleService)
    {
        _articleService = articleService;
    }

    [HttpGet("all")]
    public async Task<IEnumerable<ArticleRespons>>GetAll()
    {
        return await _articleService.GetAllAsync();
    }
    [HttpGet("type{typeId}")]
    public async Task<IEnumerable<ArticleRespons>> GetAllByType(int typeId)
    {
        return await _articleService.GetAllAsync(typeId);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var respons = await _articleService.GetAsync(id);
        if (respons != null)
            return Ok(respons);

        else
            return BadRequest();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(ArticleRequest req)
    {

        if (ModelState.IsValid) 
        {
            var respons = await _articleService.CreateAsync(req);
            return Created("", respons);
        }
        return BadRequest();

    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateArticleAsync(int id, ArticleRequest articleToUpdate)
    {
        if(await _articleService.UpdateAsync(id, articleToUpdate) != null)
            return Ok();
        else 
            return BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        if (await _articleService.DeleteAsync(id) is OkResult)
        return Ok();
        else 
        return BadRequest();
    }
}
