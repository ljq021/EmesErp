#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Surging.Core.Common;
using Emes.Core.Data;
using Emes.Erp.ISystem;
using Emes.Erp.ISystem.Dtos.Roles;
using Emes.Erp.System.Models;
using Surging.Core.AutoMapper;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.System.Implementation
{
    [ModuleName("Role")]
    public class RoleService : ProxyServiceBase, IRoleService
    {
        private readonly IRepository<Role> _roleRepository;
        public RoleService(IRepository<Role> roleRepository
            )
        {
            _roleRepository = roleRepository;
        }
        /// <summary>
        /// 创建角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<Result<RoleDto>> Create(CreateRoleDto request)
        {
            if (request.IsValid())
            {
                var role = request.MapTo<Role>();
                _roleRepository.Add(role);
                return Result.Ok(role.MapTo<RoleDto>());
            }
            else
            {
                return Result.Fail<RoleDto>(request.Message());
            }
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<RoleDto>> Delete(DeleteRoleDto request)
        {
            if (request.IsValid())
            {
                var role = await _roleRepository.GetById(request.Id);
                if (role != null)
                {
                    await _roleRepository.Remove(role);
                    return await Result.Ok(role.MapTo<RoleDto>());
                }
                return await Result.NotFound<RoleDto>();

            }
            else
            {
                return await Result.Fail<RoleDto>(request.Message());
            }
        }

        /// <summary>
        /// 根据Id获取角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<RoleDto>> GetById(long id)
        {

            var role = await _roleRepository.GetById(id);
            if (role != null)
            {
                return await Result.Ok(role.MapTo<RoleDto>());
            }
            return await Result.NotFound<RoleDto>();

        }

        /// <summary>
        /// 查询角色列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<Result<IEnumerable<RoleDto>>> Query(QueryRoleDto request)
        {
            var query = _roleRepository.Query;
           
            return Result.Ok(query.MapTo<RoleDto>());
            
        }

        /// <summary>
        /// 更新角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Result<RoleDto>> Update(UpdateRoleDto request)
        {
            if (request.IsValid())
            {
                var role = await _roleRepository.GetById(request.Id);
                if (role != null)
                {
                    role = request.MapTo(role);
                    await _roleRepository.Update(role);
                    return await Result.Ok(role.MapTo<RoleDto>());
                }
                return await Result.NotFound<RoleDto>();

            }
            else
            {
                return await Result.Fail<RoleDto>(request.Message());
            }
        }
    }
}