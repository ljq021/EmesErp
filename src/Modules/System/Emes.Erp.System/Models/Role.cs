#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System;
using Emes.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Emes.Erp.System.Models
{
    /// <summary>
    /// 角色
    /// Desc:角色领域模型
    /// </summary>
    public class Role: EntityBase, IAggregateRoot
    {
         /// <summary>
        /// 名称
        /// Desc:名称
        /// </summary>
        [Required(ErrorMessage = "名称是必填项")]
        public string Name { get; set; }
/// <summary>
        /// 备注
        /// Desc:岗位编备注号
        /// </summary>
        
        public string Notes { get; set; }
/// <summary>
        /// 系统角色
        /// Desc:是否系统角色
        /// </summary>
        [Required(ErrorMessage = "系统角色是必填项")]
        public bool IsSystemRole { get; set; }
    }
}

