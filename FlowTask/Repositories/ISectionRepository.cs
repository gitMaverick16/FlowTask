using FlowTask.Models;

namespace FlowTask.Repositories
{
    public interface ISectionRepository
    {
        Task<Section> Get(string id);
        Task<List<Section>> GetAll();
        Task<Section> Update(Section section);
        Task<Section> Delete(Section section);
        Task<Section> Add(Section section);
    }
}
