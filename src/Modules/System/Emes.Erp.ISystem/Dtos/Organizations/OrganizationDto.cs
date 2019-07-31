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
    /// 组织机构详情Dto
    /// Desc:组织机构领域模型详情Dto
    /// </summary>
    public class OrganizationDto: DtoWithIdBase
    {
         /// <summary>
        /// 上级机构
        /// Desc:上级机构
        /// </summary>
        [Required(ErrorMessage = "上级机构是必填项")]
        public string ParentId { get; set; }
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
        [Required(ErrorMessage = "助记码是必填项")]
        public string MnemonicCode { get; set; }
/// <summary>
        /// 分公司
        /// Desc:是否分公司
        /// </summary>
        [Required(ErrorMessage = "分公司是必填项")]
        public bool IsFiliale { get; set; }
/// <summary>
        /// 分店
        /// Desc:是否分店
        /// </summary>
        [Required(ErrorMessage = "分店是必填项")]
        public bool IsSubbranch { get; set; }
    }
}

