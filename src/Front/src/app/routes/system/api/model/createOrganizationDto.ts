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
 * 创建组织机构Dto  Desc:创建组织机构领域模型Dto
 */
export interface CreateOrganizationDto { 
    /**
     * 上级机构  Desc:上级机构
     */
    parentId: number;
    /**
     * 机构编号  Desc:机构编号
     */
    no: string;
    /**
     * 机构名称  Desc:机构名称
     */
    name: string;
    /**
     * 助记码  Desc:助记码
     */
    mnemonicCode?: string;
    /**
     * 是否分公司  Desc:是否分公司
     */
    isFiliale?: boolean;
    /**
     * 是否分店  Desc:是否分店
     */
    isSubbranch?: boolean;
}
