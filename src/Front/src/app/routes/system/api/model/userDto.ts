/**
 * Emes.Erp.ISystem
 *
 * OpenAPI spec version: 1.0.0.0
 * 
 *
 * NOTE: 当前文件是由工具自动生成，请不要修改.
 * Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
 * Do not edit the class manually.
 */


/**
 * 用户领域模型详情Dto  Desc:用户详情Dto
 */
export interface UserDto { 
    /**
     * 姓名  Desc:用户姓名
     */
    name: string;
    /**
     * 密码  Desc:用户密码
     */
    password: string;
    /**
     * 系统账户  Desc:系统账户
     */
    isSystemAccount: boolean;
    /**
     * 系统名称  Desc:系统名称
     */
    systemName: string;
    /**
     * 锁定  Desc:是否锁定
     */
    isLock: boolean;
    /**
     * 生效时间  Desc:生效时间
     */
    effectiveDate: Date;
    /**
     * 单点登录  Desc:限制单点登录
     */
    isLimitDuplicateLogin: boolean;
    /**
     * 备注  Desc:备注
     */
    notes?: string;
}
