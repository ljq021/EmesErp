using Emes.Core.Models;

namespace Emes.Core.Data
{
    public class Repository<T> : RepositoryWithTypedId<T, long>, IRepository<T>
           where T : class, IEntityWithTypedId<long>
    {
        public Repository(EmesDbContext context) : base(context)
        {
        }
    }
}
