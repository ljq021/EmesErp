/**
 * Emes.Erp.ISystem.ec
 *
 * OpenAPI spec version: 1.0.0.0
 * 
 *
 * NOTE: 当前文件是由工具自动生成，请不要修改.
 * Copyright (c) 2019-present anber<shuangyan_m@hotmail.com>
 * Do not edit the class manually.
 */
import { AclDto } from './aclDto';


export interface HttpResultMessageAclDto { 
    entity?: AclDto;
    isSucceed?: boolean;
    message?: string;
    statusCode?: number;
}