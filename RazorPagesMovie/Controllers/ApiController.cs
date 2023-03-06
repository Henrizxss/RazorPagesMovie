using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Controllers
{
    public class ApiController
    {
        [ApiController]
        [Route("v1/movies")]
        public class CategoryController : ControllerBase
        {
            [HttpGet]  
            [Route("")]

            public async Task<ActionResult<List<Movie>>> Get([FromServices] RazorPagesMovieContext context)
            {
                var movies = await context.Movie.ToListAsync();
                return movies;
            }
            [HttpPost]
            [Route("")]
            
            public async Task<ActionResult<Movie>> Post(
                [FromServices] RazorPagesMovieContext context,
                [FromBody]Movie model)
            {
                if (!ModelState.IsValid)
                {
                    context.Movie.Add(model);
                    await context.SaveChangesAsync();
                    return model;
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
        }
    }
}
