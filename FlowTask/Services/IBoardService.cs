using FlowTask.Models;

namespace FlowTask.Services
{
    public interface IBoardService
    {
        Task<Board> Get(string id);
        Task<List<Board>> GetAll();
        Task<Board> Update(Board board);
        Task<Board> Delete(Board board);
        Task<Board> Add(Board board);
    }
}
