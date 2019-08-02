#region Copyright
//======================================================================
//        NOTE: 当前文件是由工具自动生成，允许修改，覆盖请谨慎.
//        Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
//======================================================================
#endregion
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Emes.Core.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Emes.Erp.ISystem.Dtos.Organizations
{
    /// <summary>
    /// 测试Dto
    /// Desc:测试Dto
    /// </summary>
    public class TestDto : DtoWithIdBase
    {
        /// <summary>
        ///字符串测试
        /// </summary>
        [Required(ErrorMessage = "字符串是必填项")]
        [StringLength(160, ErrorMessage = "StrTest 不长于160")]
        [Display(Name ="字符串",Description ="字符串测试")]
        public string StrTest { get; set; }

        /// <summary>
        /// 邮箱测试
        /// </summary>
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
      ErrorMessage = "邮件地址不正确")]
        [Display(Name = "邮箱", Description = "邮箱测试")]
        public string Email { get; set; }
        /// <summary>
        /// 邮箱2
        /// </summary>
        [EmailAddress]
        public string Email2 { get; set; }

        /// <summary>
        /// decimal测试
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0.00", "49.99")]
        [Display(Name = "数字", Description = "数字测试")]
        public decimal Total { get; set; }

        /// <summary>
        /// 字符串长度
        /// </summary>
        [MaxLength(220,ErrorMessage ="最大长度不超220")]
        [MinLength(5,ErrorMessage ="最小长度不小于5")]
        [Display(Name = "字符串长度", Description = "字符串长度测试")]
        public string MinMaxStc { get; set; }
        /// <summary>
        /// 密码测试
        /// </summary>
        [Required(ErrorMessage ="密码是必填项")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        /// <summary>
        /// 只读测试
        /// </summary>
        [ReadOnly(true)]
        public string ReadOnly { get; set; }
        /// <summary>
        /// 隐藏测试
        /// </summary>
        [HiddenInput]
        public string Hidden { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [Range(typeof(DateTime), "0.00", "49.99")]
        public DateTime DateTime { get; set; }

        public int MyProperty { get; set; }
    }
}

