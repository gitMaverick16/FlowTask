using AutoMapper;
using FlowTask.DTOs;
using FlowTask.Models;
using FlowTask.Repositories;

namespace FlowTask.Services
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;
        private readonly IMapper _mapper;
        public BoardService(
            IBoardRepository boardRepository,
            IMapper mapper)
        {
            _boardRepository = boardRepository;
            _mapper = mapper;
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

        public async Task<Board> Update(UpdateBoardDTO board)
        {
            return await _boardRepository.Update(_mapper.Map<Board>(board));
        }

        public async Task<Board> Add(CreateBoardDTO board)
        {
            return await _boardRepository.Add(_mapper.Map<Board>(board));
        }
    }
}
