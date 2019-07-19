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
/* tslint:disable:no-unused-variable member-ordering */
import { Injectable } from '@angular/core';
import { _HttpClient } from '@delon/theme';
import { Observable } from 'rxjs';
import {
  HttpClient,
  HttpHeaders,
  HttpParams,
  HttpResponse,
  HttpEvent
} from "@angular/common/http";
import { CustomHttpUrlEncodingCodec } from "../encoder";

import { HttpResultMessageResultIEnumerableRoleDto } from '../model/httpResultMessageResultIEnumerableRoleDto';
import { HttpResultMessageResultRoleDto } from '../model/httpResultMessageResultRoleDto';
import { Request10 } from '../model/request10';
import { Request11 } from '../model/request11';
import { Request8 } from '../model/request8';
import { Request9 } from '../model/request9';
 


@Injectable({
  providedIn: 'root'
})
export class IRoleService {


    constructor(protected http:_HttpClient) {
    }


    /**
     * 创建角色
     * 
     * @param request 
* @param servicekey 
     */
    public create(request: Request8, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultRoleDto>;
    public create(request: Request8, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultRoleDto>>;
    public create(request: Request8, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultRoleDto>>;
    public create(request: Request8, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling create.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultRoleDto>(`/api/role/create`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 删除角色
     * 
     * @param request 
* @param servicekey 
     */
    public delete(request: Request9, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultRoleDto>;
    public delete(request: Request9, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultRoleDto>>;
    public delete(request: Request9, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultRoleDto>>;
    public delete(request: Request9, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling delete.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultRoleDto>(`/api/role/delete`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 根据Id获取角色
     * 
     * @param id 
* @param servicekey 
     */
    public getbyid(id: number, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultRoleDto>;
    public getbyid(id: number, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultRoleDto>>;
    public getbyid(id: number, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultRoleDto>>;
    public getbyid(id: number, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (id === null || id === undefined) {
            throw new Error('Required parameter id was null or undefined when calling getbyid.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }
        if (id !== undefined && id !== null) {
            queryParameters = queryParameters.set('id', <any>id);
        }


        return this.http.get<HttpResultMessageResultRoleDto>(`/api/role/getbyid`,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 查询角色列表
     * 
     * @param request 
* @param servicekey 
     */
    public query(request: Request10, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultIEnumerableRoleDto>;
    public query(request: Request10, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultIEnumerableRoleDto>>;
    public query(request: Request10, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultIEnumerableRoleDto>>;
    public query(request: Request10, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling query.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultIEnumerableRoleDto>(`/api/role/query`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 更新角色
     * 
     * @param request 
* @param servicekey 
     */
    public update(request: Request11, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultRoleDto>;
    public update(request: Request11, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultRoleDto>>;
    public update(request: Request11, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultRoleDto>>;
    public update(request: Request11, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling update.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultRoleDto>(`/api/role/update`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

}
