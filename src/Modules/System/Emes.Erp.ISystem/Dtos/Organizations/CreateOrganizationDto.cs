﻿#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System;
using System.ComponentModel.DataAnnotations;
using Emes.Core.Dtos;

namespace Emes.Erp.ISystem.Dtos.Organizations
{
    /// <summary>
    /// 创建组织机构Dto
    /// Desc:创建组织机构领域模型Dto
    /// </summary>
    public class CreateOrganizationDto: DtoBase
    {
         /// <summary>
        /// 上级机构
        /// Desc:上级机构
        /// </summary>
        [Required(ErrorMessage = "上级机构是必填项")]
        public long ParentId { get; set; }
/// <summary>
        /// 机构编号
        /// Desc:机构编号
        /// </summary>
        [Required(ErrorMessage = "机构编号是必填项")]
        public string No { get; set; }
/// <summary>
        /// 机构名称
        /// Desc:机构名称
        /// </summary>
        [Required(ErrorMessage = "机构名称是必填项")]
        public string Name { get; set; }
/// <summary>
        /// 助记码
        /// Desc:助记码
        /// </summary>
        
        public string MnemonicCode { get; set; }
/// <summary>
        /// 是否分公司
        /// Desc:是否分公司
        /// </summary>
        
        public bool IsFiliale { get; set; }
/// <summary>
        /// 是否分店
        /// Desc:是否分店
        /// </summary>
        
        public bool IsSubbranch { get; set; }
    }
}

