using System.Threading.Tasks;
using Emes.Erp.Basic.Interface;
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.Basic
{
    public class ManagerService : ProxyServiceBase, IManagerService
    {
        public Task<string> SayHello(string name)
        {
            return Task.FromResult($"{name} say:hello");
        }
    }

}
