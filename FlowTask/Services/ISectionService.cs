using FlowTask.Models;

namespace FlowTask.Services
{
    public interface ISectionService
    {
        Task<Section> Get(string id);
        Task<List<Section>> GetAll();
        Task<Section> Update(Section section);
        Task<Section> Delete(Section section);
        Task<Section> Add(Section section);
    }
}
