using FlowTask.Models;
using FlowTask.Repositories;

namespace FlowTask.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;
        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }
        public async Task<Card> Add(Card card)
        {
            return await _cardRepository.Add(card);
        }

        public async Task<Card> Delete(Card card)
        {
            return await _cardRepository.Delete(card);
        }

        public async Task<Card> Get(string id)
        {
            return await _cardRepository.Get(id);
        }

        public async Task<List<Card>> GetAll()
        {
            return await _cardRepository.GetAll();
        }

        public async Task<Card> Update(Card card)
        {
            return await _cardRepository.Update(card);
        }
    }
}
