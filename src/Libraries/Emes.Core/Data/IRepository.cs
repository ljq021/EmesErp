using Emes.Core.Models;

namespace Emes.Core.Data
{
    public interface IRepository<T> : IRepositoryWithTypedId<T, long> where T : IEntityWithTypedId<long>, IAggregateRoot
    {
    }
}
