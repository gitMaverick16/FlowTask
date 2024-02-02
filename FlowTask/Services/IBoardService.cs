using FlowTask.DTOs;
using FlowTask.Models;

namespace FlowTask.Services
{
    public interface IBoardService
    {
        Task<Board> Get(string id);
        Task<List<Board>> GetAll();
        Task<Board> Update(UpdateBoardDTO board);
        Task<Board> Delete(Board board);
        Task<Board> Add(CreateBoardDTO board);
    }
}
