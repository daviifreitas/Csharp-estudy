using eTickets.Models;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository <TEntity> where TEntity : class, IEntityBase, new()
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(int id);
        void Add(TEntity actor);
        Task<TEntity> Update(int id, TEntity newActorData);
        Task Delete(int id);
    }
}
