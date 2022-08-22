using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _appDbContext; 

        public CinemaController (AppDbContext context)
        {
            this._appDbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _appDbContext.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
