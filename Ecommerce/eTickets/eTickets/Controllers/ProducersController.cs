using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProducersController (AppDbContext context)
        {
            this._appDbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _appDbContext.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
