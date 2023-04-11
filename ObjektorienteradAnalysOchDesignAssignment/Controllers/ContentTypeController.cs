using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObjektorienteradAnalysOchDesignAssignment.DTOs;
using ObjektorienteradAnalysOchDesignAssignment.Repositories;


namespace ObjektorienteradAnalysOchDesignAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentTypeController : ControllerBase
    {
        private readonly ContentTypeRepository _contentTypeRepo;

        public ContentTypeController(ContentTypeRepository contentTypeRepo)
        {
            _contentTypeRepo = contentTypeRepo;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(ContentTypeRequest req)
        {

            if (ModelState.IsValid)
            {
                var respons = await _contentTypeRepo.CreateAsync(req);
                return Created("", respons);
            }
            return BadRequest();

        }
    }
}
