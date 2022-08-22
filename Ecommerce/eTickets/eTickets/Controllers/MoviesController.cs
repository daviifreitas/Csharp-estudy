using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public MoviesController (AppDbContext context)
        {
            this._appDbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _appDbContext.Cinemas.ToListAsync();
            return View(allMovies);
        }
    }
}
