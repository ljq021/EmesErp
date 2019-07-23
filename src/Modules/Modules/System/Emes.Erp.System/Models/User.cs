using Emes.Core;
using Emes.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Emes.Erp.System.Models
{
    /// <summary>
    /// 用户领域模型
    /// 用户
    /// </summary>
    public class User: EntityBase, IAggregateRoot
    {
         /// <summary>
        /// 姓名
        /// 用户姓名
        /// </summary>
        [Required(ErrorMessage = "姓名是必填项")]
        public string Name { get; set; }
/// <summary>
        /// 密码
        /// 用户密码
        /// </summary>
        [Required(ErrorMessage = "密码是必填项")]
        public string Password { get; set; }
/// <summary>
        /// 生效时间
        /// 生效时间
        /// </summary>
        [Required(ErrorMessage = "生效时间是必填项")]
        public DateTime EffectiveDate { get; set; }
/// <summary>
        /// 系统名
        /// 系统名
        /// </summary>
        [Required(ErrorMessage = "系统名是必填项")]
        public string SystemName { get; set; }
    }
}

