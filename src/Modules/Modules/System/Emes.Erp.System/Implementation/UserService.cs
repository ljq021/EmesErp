using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Core.Data;
using Emes.Erp.ISystem;
using Emes.Erp.ISystem.Dtos.Users;
using Emes.Erp.System.Models;
using Surging.Core.AutoMapper;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.ProxyGenerator;

namespace Emes.Erp.System.Implementation
{
    [ModuleName("User")]
    public class UserService : ProxyServiceBase, IUserService
    {
        private readonly IRepository<User> _"User"Repository;
        public UserService(IRepository<<User> "User"Repository
            )
        {
            _"User"Repository = "User"Repository;
        }
        public Task<Result<UserDto>> Create(CreateUserDto request)
        {
            if (request.IsValid())
            {
                var "User" = request.MapTo<User>();
                _"User"Repository.Add("User");
                return Result.Ok("User".MapTo<UserDto>());
            }
            else
            {
                return Result.Fail<UserDto>(request.Message());
            }
        }

        public async Task<Result<UserDto>> Delete(DeleteUserDto request)
        {
            if (request.IsValid())
            {
                var "User" = await _"User"Repository.GetById(request.Id);
                if ("User" != null)
                {
                    await _"User"Repository.Remove("User");
                    return await Result.Ok("User".MapTo<UserDto>());
                }
                return await Result.NotFound<UserDto>();

            }
            else
            {
                return await Result.Fail<UserDto>(request.Message());
            }
        }

        public async Task<Result<UserDto>> GetById(long id)
        {

            var "User" = await _"User"Repository.GetById(id);
            if ("User" != null)
            {
                return await Result.Ok("User".MapTo<UserDto>());
            }
            return await Result.NotFound<UserDto>();

        }

        public Task<Result<IEnumerable<UserDto>>> Query(QueryUserDto request)
        {
            var query = _"User"Repository.Query;
           
            return Result.Ok(query.MapTo<UserDto>());
            ;
        }

        public async Task<Result<UserDto>> Update(UpdateUserDto request)
        {
            if (request.IsValid())
            {
                var "User" = await _"User"Repository.GetById(request.Id);
                if ("User" != null)
                {
                    await _"User"Repository.Update(org);
                    return await Result.Ok("User".MapTo<UserDto>());
                }
                return await Result.NotFound<UserDto>();

            }
            else
            {
                return await Result.Fail<UserDto>(request.Message());
            }
        }
    }
}