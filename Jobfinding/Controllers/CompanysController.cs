using Jobfinding.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jobfinding.Controllers
{
    public class CompanysController : Controller
    {
        private readonly AppDbContext _context;
        public CompanysController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCompanies =await  _context.Companies.ToListAsync();
            return View(allCompanies);
        }
    }
}
