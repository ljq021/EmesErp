using Autofac;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Surging.Core.CPlatform.Utilities;

namespace Emes.Core.Data
{
    public partial class DefaultValueGenerator : ValueGenerator<long>
    {
        private readonly IIdWorker _idWorker;
        public DefaultValueGenerator()
        {
            _idWorker = ServiceLocator.Current.Resolve<IIdWorker>();
        }
        public override bool GeneratesTemporaryValues => false;

        public override long Next(EntityEntry entry)
        {
            return _idWorker.NextId();
        }
    }
}
