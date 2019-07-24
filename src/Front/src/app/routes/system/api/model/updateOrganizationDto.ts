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
 * 更新组织机构Dto  Desc:更新组织机构领域模型Dto
 */
export interface UpdateOrganizationDto { 
    /**
     * 上级机构  上级机构
     */
    parentId: number;
    /**
     * 机构编号  机构编号
     */
    no: string;
    /**
     * 机构名称  机构名称
     */
    name: string;
    /**
     * 助记码  助记码
     */
    mnemonicCode?: string;
    /**
     * 是否分公司  是否分公司
     */
    isFiliale?: boolean;
    /**
     * 是否分店  是否分店
     */
    isSubbranch?: boolean;
    id?: number;
}
