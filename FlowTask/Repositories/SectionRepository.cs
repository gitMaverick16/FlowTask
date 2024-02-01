using FlowTask.Context;
using FlowTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowTask.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private readonly FlowTaskContext _context;
        private readonly DbSet<Section> _section;
        public SectionRepository(FlowTaskContext context)
        {
            _context = context;
            _section = context.Sections;
        }
        public async Task<Section> Add(Section section)
        {
            _section.Add(section);
            await _context.SaveChangesAsync();
            return section;
        }

        public async Task<Section> Delete(Section section)
        {
            _section.Remove(section);
            await _context.SaveChangesAsync();
            return section;
        }

        public async Task<Section> Get(string id)
        {
            return await _section.FirstOrDefaultAsync(s => s.Id.Equals(id));
        }

        public async Task<List<Section>> GetAll()
        {
            return await _section.Where(s => true).ToListAsync();
        }

        public async Task<Section> Update(Section section)
        {
            _section.Update(section);
            await _context.SaveChangesAsync();
            return section;
        }
    }
}
