using AutoMapper;
using FlowTask.DTOs;
using FlowTask.Models;
using FlowTask.Repositories;

namespace FlowTask.Services
{
    public class SectionService : ISectionService
    {
        private readonly IMapper _mapper;
        private readonly ISectionRepository _sectionRepository;
        public SectionService(
            IMapper mapper,
            ISectionRepository sectionRepository)
        {
            _mapper = mapper;
            _sectionRepository = sectionRepository;
        }
        public async Task<Section> Add(CreateSectionDTO section)
        {
            return await _sectionRepository.Add(_mapper.Map<Section>(section));
        }

        public async Task<Section> Delete(Section section)
        {
            return await _sectionRepository.Delete(section);
        }

        public async Task<Section> Get(string id)
        {
            return await _sectionRepository.Get(id);
        }

        public async Task<List<Section>> GetAll()
        {
            return await _sectionRepository.GetAll();
        }

        public async Task<Section> Update(UpdateSectionDTO section)
        {
            return await _sectionRepository.Update(_mapper.Map<Section>(section));
        }
    }
}
