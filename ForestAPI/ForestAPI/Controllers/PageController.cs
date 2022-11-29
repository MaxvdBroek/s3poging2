using ForestAPI.Data;
using ForestAPI.DTO_s;
using ForestAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ForestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly ForestDbContext _context;
        public PageController(ForestDbContext context) => _context = context;

        [HttpGet("all")]
           public async Task<IEnumerable<Page>> Get()        
            =>await _context.Pages.ToListAsync();

        [HttpGet("id")]
        [ProducesResponseType(typeof(Page), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var page = await _context.Pages.FindAsync(id);
            return page == null ? NotFound() : Ok(page);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreatePage(PageDTO page)
        {
            var newPage = new Page
            {
                Title = page.Title,
                Information = page.Information,
                CategoryID = page.CategoryID,
                LastUpdated = DateTime.Now,
            };

            await _context.Pages.AddAsync(newPage);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new {id = page.PageID}, page);

        }

    }
}
