using Jobfinding.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jobfinding.Controllers
{
    public class JobsController : Controller
    {
        private readonly AppDbContext _context;
        public JobsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var alljobs = await _context.Jobs.ToListAsync();
            return View(alljobs);
        }
    }
}
