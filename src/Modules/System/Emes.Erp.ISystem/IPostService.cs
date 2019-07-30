#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System.Collections.Generic;
using System.Threading.Tasks;
using Emes.Erp.ISystem.Dtos.Posts;
using Surging.Core.Common;
using Surging.Core.CPlatform.Filters.Implementation;
using Surging.Core.CPlatform.Ioc;
using Surging.Core.CPlatform.Runtime.Server.Implementation.ServiceDiscovery.Attributes;

namespace Emes.Erp.ISystem
{
    /// <summary>
    /// 岗位服务接口
    /// </summary>
    [ServiceBundle("api/{Service}")]
    public interface IPostService : IServiceKey
    {
        /// <summary>
        /// 创建岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<PostDto>> Create(CreatePostDto request);

        /// <summary>
        /// 更新岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<PostDto>> Update(UpdatePostDto request);

        /// <summary>
        /// 删除岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<PostDto>> Delete(DeletePostDto request);

        /// <summary>
        /// 查询岗位列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<IEnumerable<PostDto>>> Query(QueryPostDto request);

        /// <summary>
        /// 根据Id获取岗位
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Authorization(AuthType = AuthorizationType.JWT)]
        Task<Result<PostDto>> GetById(long id);


    }
}
