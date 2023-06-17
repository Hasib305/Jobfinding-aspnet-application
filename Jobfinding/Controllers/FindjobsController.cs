using Jobfinding.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jobfinding.Controllers
{
    public class FindjobsController : Controller
    {
        private readonly AppDbContext _context;
        public FindjobsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Find = await _context.Findjobs.Include(n => n.Jobs).OrderBy(n => n.Name).ToListAsync();
            return View(Find);
        }
    }
}
