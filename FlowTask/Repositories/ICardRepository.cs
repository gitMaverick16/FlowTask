using FlowTask.Models;

namespace FlowTask.Repositories
{
    public interface ICardRepository
    {
        Task<Card> Get(string id);
        Task<List<Card>> GetAll();
        Task<Card> Update(Card card);
        Task<Card> Delete(Card card);
        Task<Card> Add(Card card);
    }
}
