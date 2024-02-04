using FlowTask.Context;
using FlowTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowTask.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        private readonly FlowTaskContext _context;
        private readonly DbSet<Board> _board;
        public BoardRepository(FlowTaskContext context)
        {
            _context = context;
            _board = context.Boards;
        }
        public async Task<Board> Get(string id)
        {
            var asd = await _board.FirstOrDefaultAsync(b => b.Id.ToString() == id);
            return asd;
        }

        public async Task<List<Board>> GetAll()
        {
            return await _board.Where(b => true).ToListAsync();
        }

        public async Task<Board> Update(Board board)
        {
            _board.Update(board);
            await _context.SaveChangesAsync();
            return board;
        }

        public async Task<Board> Delete(Board board)
        {
            _board.Remove(board);
            await _context.SaveChangesAsync();
            return board;
        }

        public async Task<Board> Add(Board board)
        {
            _board.Add(board);
            await _context.SaveChangesAsync();
            return board;
        }
    }
}
