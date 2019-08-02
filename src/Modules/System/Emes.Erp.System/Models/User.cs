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
    /// 用户
    /// Desc:用户领域模型
    /// </summary>
    public class User : EntityBase, IAggregateRoot
    {

        public Guid UserGuid { get; set; }

        /// <summary>
        /// 密码
        /// Desc:用户密码
        /// </summary>
        [Required(ErrorMessage = "密码是必填项")]
        public string Password { get; set; }
        /// <summary>
        /// 系统账户
        /// Desc:是否系统账户
        /// </summary>
        [Required(ErrorMessage = "系统账户是必填项")]
        public bool IsSystemAccount { get; set; }
        /// <summary>
        /// 姓名
        /// Desc:用户姓名
        /// </summary>
        [Required(ErrorMessage = "姓名是必填项")]
        public string Name { get; set; }
        /// <summary>
        /// 系统名称
        /// Desc:系统名称
        /// </summary>
        [Required(ErrorMessage = "系统名称是必填项")]
        public string SystemName { get; set; }
        /// <summary>
        /// 锁定
        /// Desc:是否锁定
        /// </summary>
        [Required(ErrorMessage = "锁定是必填项")]
        public bool IsLock { get; set; }
        /// <summary>
        /// 生效时间
        /// Desc:生效时间
        /// </summary>
        [Required(ErrorMessage = "生效时间是必填项")]
        public DateTimeOffset EffectiveDate { get; set; }
        /// <summary>
        /// 单点登录
        /// Desc:限制单点登录
        /// </summary>
        [Required(ErrorMessage = "单点登录是必填项")]
        public bool IsLimitDuplicateLogin { get; set; }
        /// <summary>
        /// 备注
        /// Desc:备注
        /// </summary>
        [Required(ErrorMessage = "备注是必填项")]
        public string Notes { get; set; }
    }
}

