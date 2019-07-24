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
 * 更新用户领域模型Dto  Desc:更新用户Dto
 */
export interface UpdateUserDto { 
    /**
     * 姓名  用户姓名
     */
    name: string;
    /**
     * 密码  用户密码
     */
    password: string;
    /**
     * 系统账户  系统账户
     */
    isSystemAccount: boolean;
    /**
     * 系统名称  系统名称
     */
    systemName: string;
    /**
     * 锁定  是否锁定
     */
    isLock: boolean;
    /**
     * 生效时间  生效时间
     */
    effectiveDate: Date;
    /**
     * 单点登录  限制单点登录
     */
    isLimitDuplicateLogin: boolean;
    /**
     * 备注  备注
     */
    notes?: string;
    id?: number;
}
