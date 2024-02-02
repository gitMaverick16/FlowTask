using FlowTask.DTOs;
using FlowTask.Models;

namespace FlowTask.Services
{
    public interface ISectionService
    {
        Task<Section> Get(string id);
        Task<List<Section>> GetAll();
        Task<Section> Update(UpdateSectionDTO section);
        Task<Section> Delete(Section section);
        Task<Section> Add(CreateSectionDTO section);
    }
}
