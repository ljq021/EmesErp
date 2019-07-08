using System;
using System.Collections.Generic;
using System.Text;

namespace Emes.Core.Models.Enums
{
    public enum EmesStatus
    {
        /// <summary>
        /// 未指定
        /// </summary>
        All = 1,
        /// <summary>
        /// 已禁用
        /// </summary>
        Forbidden = 2,
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 3
    }

    /// <summary>
    /// 权限类型
    /// </summary>
    public enum PermissionType
    {
        /// <summary>
        /// 菜单
        /// </summary>
        Menu = 1,
        /// <summary>
        /// 按钮/操作/功能
        /// </summary>
        Action = 2,
        /// <summary>
        /// 按钮/操作/功能
        /// </summary>
        Field = 3
    }

    public enum YesOrNo
    {
        /// <summary>
        /// 所有
        /// </summary>
        All = 1,
        /// <summary>
        /// 否
        /// </summary>
        No = 2,
        /// <summary>
        /// 是
        /// </summary>
        Yes = 3
    }
}
