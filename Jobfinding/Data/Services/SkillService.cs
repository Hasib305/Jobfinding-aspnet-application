using Jobfinding.Models;
using Microsoft.EntityFrameworkCore;

namespace Jobfinding.Data.Services
{
    public class SkillService : ISkillService
    {
        private readonly AppDbContext _context;
        public SkillService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Skill skill)
        {
           await _context.Skills.AddAsync(skill);
           await _context.SaveChangesAsync();
        }

        public async Task  DeleteAsync(int id)
        {
            var result = await _context.Skills.FirstOrDefaultAsync(n => n.Id == id);
            _context.Skills.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Skill>> GetAllAsync()
        {
           var result=await _context.Skills.ToListAsync();
            return result;
        }

        public async Task<Skill> GetByIdAsync(int id)
        {
            var result=await _context.Skills.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }
         
        public async Task<Skill> UpdateAsync(int id, Skill newSkill)
        {
            _context.Update(newSkill);
            await _context.SaveChangesAsync();
            return newSkill;
        }
    }
}
