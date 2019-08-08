#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Core.Data;
using Emes.Erp.ISystem;
using Emes.Erp.ISystem.Dtos.Roles;
using Emes.Erp.System.Models;
using Surging.Core.AutoMapper;
using Surging.Core.CPlatform.Exceptions;
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
        public async Task<RoleDto> Create(CreateRoleDto request)
        {
            if (!request.IsValid())
            {
                throw new ValidateException(request.Message());
            }
            var role = request.MapTo<Role>();
            await  _roleRepository.Add(role);
            return role.MapTo<RoleDto>();
           
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RoleDto> Delete(DeleteRoleDto request)
        {
            if (!request.IsValid())
            {
                throw new ValidateException(request.Message());
            }
            var role = await _roleRepository.GetById(request.Id);
            if (role == null)
            {
               throw new BusinessException(ExceptionMessage.NotFound);
            }
            await _roleRepository.Remove(role);
            return role.MapTo<RoleDto>();
        }

        /// <summary>
        /// 根据Id获取角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RoleDto> GetById(long id)
        {

            var role = await _roleRepository.GetById(id);
            if (role == null)
            {
                throw new BusinessException(ExceptionMessage.NotFound);
            }
            return role.MapTo<RoleDto>();

        }

        /// <summary>
        /// 查询角色列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<IEnumerable<RoleDto>> Query(QueryRoleDto request)
        {
            var query = _roleRepository.Query.ToList();
           
            return Task.FromResult(query.MapTo<RoleDto>());
        }

        /// <summary>
        /// 更新角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<RoleDto> Update(UpdateRoleDto request)
        {
            if (!request.IsValid())
            {
                throw new ValidateException(request.Message());
            }
            var role = await _roleRepository.GetById(request.Id);
            if (role == null)
            {
                throw new BusinessException(ExceptionMessage.NotFound);
            }
            role = request.MapTo(role);
            await _roleRepository.Update(role);
            return role.MapTo<RoleDto>();
        }
    }
}