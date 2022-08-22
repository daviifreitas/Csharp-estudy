using eTickets.Models;

namespace eTickets.Data.Services.Interfaces
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Task<Actor> Get(int id);
        void Add(Actor actor);
        Task<Actor> Update(int id, Actor newActorData);
        Task Delete(int id);
    }
}
