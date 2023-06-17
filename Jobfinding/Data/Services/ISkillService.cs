using Jobfinding.Models;

namespace Jobfinding.Data.Services
{
    public interface ISkillService
    {
        Task<IEnumerable<Skill>> GetAllAsync();

        Task<Skill> GetByIdAsync(int id);
        Task AddAsync(Skill skill);
        Task<Skill> UpdateAsync(int id, Skill newSkill);
        Task DeleteAsync(int id);
    }
}
