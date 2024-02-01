using FlowTask.Models;

namespace FlowTask.Services
{
    public class SectionService : ISectionService
    {
        private readonly ISectionService _sectionService;
        public SectionService(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }
        public async Task<Section> Add(Section section)
        {
            return await _sectionService.Add(section);
        }

        public async Task<Section> Delete(Section section)
        {
            return await _sectionService.Delete(section);
        }

        public async Task<Section> Get(string id)
        {
            return await _sectionService.Get(id);
        }

        public async Task<List<Section>> GetAll()
        {
            return await _sectionService.GetAll();
        }

        public async Task<Section> Update(Section section)
        {
            return await _sectionService.Update(section);
        }
    }
}
