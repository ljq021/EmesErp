using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Core.Data;
using Emes.Erp.ISystem;
using Emes.Erp.ISystem.Dtos.Roles;
using Emes.Erp.System.Models;
using Surging.Core.AutoMapper;
using Surging.Core.CPlatform.Ioc;
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

        public async Task<Result<RoleDto>> GetById(long id)
        {

            var role = await _roleRepository.GetById(id);
            if (role != null)
            {
                return await Result.Ok(role.MapTo<RoleDto>());
            }
            return await Result.NotFound<RoleDto>();

        }

        public Task<Result<IEnumerable<RoleDto>>> Query(QueryRoleDto request)
        {
            var query = _roleRepository.Query;
            if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(q => q.Name.Contains(request.Name));
            }
            return Result.Ok(query.MapTo<RoleDto>());
        }

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
