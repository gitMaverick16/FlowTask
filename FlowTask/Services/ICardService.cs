using FlowTask.DTOs;
using FlowTask.Models;

namespace FlowTask.Services
{
    public interface ICardService
    {
        Task<Card> Get(string id);
        Task<List<Card>> GetAll();
        Task<Card> Update(UpdateCardDTO card);
        Task<Card> Delete(Card card);
        Task<Card> Add(CreateCardDTO card);
    }
}
