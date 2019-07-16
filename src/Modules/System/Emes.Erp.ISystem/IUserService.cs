using System.Collections.Generic;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Erp.ISystem.Dtos.Users;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;

namespace Emes.Erp.ISystem
{
    [ServiceBundle("api/{Service}")]
    public interface IUserService : IServiceKey
    {
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<UserDto>> Create(CreateUserDto request);

        /// <summary>
        /// 更新用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<UserDto>> Update(UpdateUserDto request);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<UserDto>> Delete(DeleteUserDto request);

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<IEnumerable<UserDto>>> Query(QueryUserDto request);

        /// <summary>
        /// 根据Id获取用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<UserDto>> GetById(long id);

        /// <summary>
        /// 认证用户
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<UserDto>> Authentication(AuthUserDto request);
    }
}
