using System.Collections.Generic;
using System.Threading.Tasks;
using Emes.Core;
using Emes.Erp.ISystem.Dtos.Posts;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;

namespace Emes.Erp.ISystem
{
    [ServiceBundle("api/{Service}")]
    public interface IPostService : IServiceKey
    {
        /// <summary>
        /// 创建岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<PostDto>> Create(CreatePostDto request);

        /// <summary>
        /// 更新岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<PostDto>> Update(UpdatePostDto request);

        /// <summary>
        /// 删除岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<PostDto>> Delete(DeletePostDto request);

        /// <summary>
        /// 查询岗位列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<IEnumerable<PostDto>>> Query(QueryPostDto request);

        /// <summary>
        /// 根据Id获取岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //
        Task<Result<PostDto>> GetById(long id);
    }
}
