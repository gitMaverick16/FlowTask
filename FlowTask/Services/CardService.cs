using AutoMapper;
using FlowTask.DTOs;
using FlowTask.Models;
using FlowTask.Repositories;

namespace FlowTask.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;
        private readonly IMapper _mapper;
        public CardService(
            ICardRepository cardRepository,
            IMapper mapper)
        {
            _cardRepository = cardRepository;
            _mapper = mapper;
        }
        public async Task<Card> Add(CreateCardDTO card)
        {
            return await _cardRepository.Add(_mapper.Map<Card>(card));
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

        public async Task<Card> Update(UpdateCardDTO card)
        {
            return await _cardRepository.Update(_mapper.Map<Card>(card));
        }
    }
}
