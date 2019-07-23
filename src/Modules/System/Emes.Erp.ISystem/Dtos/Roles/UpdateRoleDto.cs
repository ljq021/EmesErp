﻿#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System;
using System.ComponentModel.DataAnnotations;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Roles
{
    /// <summary>
    /// 更新角色Dto
    /// Desc:更新角色领域模型Dto
    /// </summary>
    public class UpdateRoleDto: DtoWithIdBase
    {
         /// <summary>
        /// 名称
        /// 名称
        /// </summary>
        [Required(ErrorMessage = "名称是必填项")]
        public string Name { get; set; }
/// <summary>
        /// 备注
        /// 岗位编备注号
        /// </summary>
        
        public string Notes { get; set; }
/// <summary>
        /// 是否系统角色
        /// 是否系统角色
        /// </summary>
        [Required(ErrorMessage = "是否系统角色是必填项")]
        public bool IsSystemRole { get; set; }
    }
}

