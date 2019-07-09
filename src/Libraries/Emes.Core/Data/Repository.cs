using Emes.Core.Models;

namespace Emes.Core.Data
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
           where T : EntityBase, IEntityWithTypedId<long>, IAggregateRoot
    {
        public Repository(IDbContext context) : base(context)
        {
        }
    }
}
