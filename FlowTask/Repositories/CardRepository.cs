using FlowTask.Context;
using FlowTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FlowTask.Repositories
{
    public class CardRepository : ICardRepository
    {
        private readonly FlowTaskContext _context;
        private readonly DbSet<Card> _card;
        public CardRepository(FlowTaskContext context)
        {
            _context = context;
            _card = context.Cards;
        }
        public async Task<Card> Add(Card card)
        {
            _card.Add(card);
            await _context.SaveChangesAsync();
            return card;
        }

        public async Task<Card> Delete(Card card)
        {
            _card.Remove(card);
            await _context.SaveChangesAsync();
            return card;
        }

        public async Task<Card> Get(string id)
        {
            return await _card.FirstOrDefaultAsync(c => c.Id.Equals(id));
        }

        public async Task<List<Card>> GetAll()
        {
            return await _card.Where(c => true).ToListAsync();
        }

        public async Task<Card> Update(Card card)
        {
            _card.Update(card);
            await _context.SaveChangesAsync();
            return card;
        }
    }
}
