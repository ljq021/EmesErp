#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System.Collections.Generic;
using System.Threading.Tasks;
using Surging.Core.Common;
using Emes.Erp.ISystem.Dtos.Roles;
using Surging.Core.CPlatform.Filters.Implementation;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;

namespace Emes.Erp.ISystem
{
    /// <summary>
    /// 角色服务接口
    /// </summary>
    [ServiceBundle("api/{Service}")]
    public interface IRoleService : IServiceKey
    {
        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<RoleDto>> Create(CreateRoleDto request);

        /// <summary>
        /// 更新角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<RoleDto>> Update(UpdateRoleDto request);

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<RoleDto>> Delete(DeleteRoleDto request);

        /// <summary>
        /// 查询角色列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<IEnumerable<RoleDto>>> Query(QueryRoleDto request);

        /// <summary>
        /// 根据Id获取角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<RoleDto>> GetById(long id);


    }
}
