using System.Collections.Generic;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Erp.ISystem.Dtos.Roles;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;

namespace Emes.Erp.ISystem
{
    [ServiceBundle("api/{Service}")]
    public interface IRoleService : IServiceKey
    {
        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<RoleDto>> Create(CreateRoleDto request);

        /// <summary>
        /// 更新角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<RoleDto>> Update(UpdateRoleDto request);

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<RoleDto>> Delete(DeleteRoleDto request);

        /// <summary>
        /// 查询角色列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<IEnumerable<RoleDto>>> Query(QueryRoleDto request);

        /// <summary>
        /// 根据Id获取角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //
        Task<Result<RoleDto>> GetById(long id);
    }
}
