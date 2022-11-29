using ForestAPI.Data;
using ForestAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ForestDbContext _context;
        public CategoryController(ForestDbContext context) => _context = context;

        [HttpGet("all")]
        public async Task<IEnumerable<Category>> Get()
         => await _context.Categories.ToListAsync();

        [HttpGet("GetAllPagesFromCategory")]
        [ProducesResponseType(typeof(Page), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Page>> SelectAllPagesCategory(int CategoryID)
        {
            var pages = (from p in _context.Pages
                         join c in _context.Categories
                         on p.CategoryID equals c.CategoryID
                         where c.CategoryID == CategoryID
                         select p).ToList();
            await _context.SaveChangesAsync();
            return Ok(pages);
        }

        [HttpGet("id")]
        [ProducesResponseType(typeof(Category), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetById(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            return category == null ? NotFound() : Ok(category);

        }




        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = category.CategoryID }, category);
        }

    }
}
