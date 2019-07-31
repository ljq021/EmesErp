#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System.Collections.Generic;
using System.Threading.Tasks;
using Emes.Erp.ISystem.Dtos.Organizations;
using Surging.Core.CPlatform.Filters.Implementation;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;

namespace Emes.Erp.ISystem
{
    /// <summary>
    /// 组织机构服务接口
    /// </summary>
    [ServiceBundle("api/{Service}")]
    public interface IOrganizationService : IServiceKey
    {
        /// <summary>
        /// 创建组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<OrganizationDto> Create(CreateOrganizationDto request);

        /// <summary>
        /// 更新组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<OrganizationDto> Update(UpdateOrganizationDto request);

        /// <summary>
        /// 删除组织机构
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<OrganizationDto> Delete(DeleteOrganizationDto request);

        /// <summary>
        /// 查询组织机构列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<IEnumerable<OrganizationDto>> Query(QueryOrganizationDto request);

        /// <summary>
        /// 根据Id获取组织机构
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<OrganizationDto> GetById(long id);


    }
}
