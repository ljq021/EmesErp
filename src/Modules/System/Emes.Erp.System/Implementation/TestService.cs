using System.Threading.Tasks;
using Emes.Erp.ISystem;
using Emes.Erp.ISystem.Dtos.Organizations;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.System.Implementation
{
    [ModuleName("Test")]
    public class TestService : ProxyServiceBase, ITestService
    {
        public Task<string> Get(TestDto request)
        {
            if (!request.IsValid())
            {
                return Task.FromResult(request.Message());
            }
            return Task.FromResult("ok");
        }
    }
}
