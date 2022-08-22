namespace eTickets.Data.Base
{
    public class EntityBaseRepository<TEntity> : IEntityBaseRepository<TEntity> where TEntity : class, IEntityBase, new()
    {
        public void Add(TEntity actor)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Update(int id, TEntity newActorData)
        {
            throw new NotImplementedException();
        }
    }
}
