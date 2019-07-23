using System.Collections.Generic;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Erp.ISystem.Dtos.Organizations;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;

namespace Emes.Erp.ISystem
{
    [ServiceBundle("api/{Service}")]
    public interface IOrganizationService : IServiceKey
    {
        /// <summary>
        /// 创建组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<OrganizationDto>> Create(CreateOrganizationDto request);

        /// <summary>
        /// 更新组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<OrganizationDto>> Update(UpdateOrganizationDto request);

        /// <summary>
        /// 删除组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<OrganizationDto>> Delete(DeleteOrganizationDto request);

        /// <summary>
        /// 查询组织机构列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<IEnumerable<OrganizationDto>>> Query(QueryOrganizationDto request);

        /// <summary>
        /// 根据Id获取组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //
        Task<Result<OrganizationDto>> GetById(long id);


    }
}
