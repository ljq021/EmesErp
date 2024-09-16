#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System;
using System.ComponentModel.DataAnnotations;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Posts
{
    /// <summary>
    /// 创建岗位Dto
    /// Desc:创建岗位领域模型Dto
    /// </summary>
    public class CreatePostDto: DtoBase
    {
         /// <summary>
        /// 部门
        /// Desc:部门
        /// </summary>
        [Required(ErrorMessage = "部门是必填项")]
        public long OrgId { get; set; }
/// <summary>
        /// 岗位编号
        /// Desc:岗位编号
        /// </summary>
        [Required(ErrorMessage = "岗位编号是必填项")]
        public string No { get; set; }
/// <summary>
        /// 岗位名称
        /// Desc:岗位名称
        /// </summary>
        [Required(ErrorMessage = "岗位名称是必填项")]
        public string Name { get; set; }
/// <summary>
        /// 助记码
        /// Desc:助记码
        /// </summary>
        [Required(ErrorMessage = "助记码是必填项")]
        public string MnemonicCode { get; set; }
/// <summary>
        /// 关键岗位
        /// Desc:是否关键岗位
        /// </summary>
        [Required(ErrorMessage = "关键岗位是必填项")]
        public bool IsKey { get; set; }
/// <summary>
        /// 所属类型
        /// Desc:所属类型
        /// </summary>
        [Required(ErrorMessage = "所属类型是必填项")]
        public int Type { get; set; }
/// <summary>
        /// 岗位职责
        /// Desc:岗位职责
        /// </summary>
        
        public string Responsibility { get; set; }
/// <summary>
        /// 岗位描述
        /// Desc:岗位描述
        /// </summary>
        
        public string Desc { get; set; }
    }
}

