using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;

namespace Emes.Erp.ISystem
{
    [ServiceBundle("api/{Service}")]
    public interface IRoleService : IServiceKey
    {
    }
}
