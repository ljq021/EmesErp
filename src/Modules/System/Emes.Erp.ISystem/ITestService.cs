using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Emes.Erp.ISystem.Dtos.Organizations;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;

namespace Emes.Erp.ISystem
{
    /// <summary>
    /// 测试服务接口
    /// </summary>
    [ServiceBundle("api/{Service}")]
    public interface ITestService : IServiceKey
    {
        Task<string> Get(TestDto request);
    }
}
