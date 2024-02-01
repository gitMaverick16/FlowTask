using FlowTask.Models;
using FlowTask.Repositories;

namespace FlowTask.Services
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;
        public BoardService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }
        public async Task<Board> Delete(Board board)
        {
            return await _boardRepository.Delete(board);
        }

        public async Task<Board> Get(string id)
        {
            return await _boardRepository.Get(id);
        }

        public async Task<List<Board>> GetAll()
        {
            return await _boardRepository.GetAll();
        }

        public async Task<Board> Update(Board board)
        {
            return await _boardRepository.Update(board);
        }

        public async Task<Board> Add(Board board)
        {
            return await _boardRepository.Add(board);
        }
    }
}
