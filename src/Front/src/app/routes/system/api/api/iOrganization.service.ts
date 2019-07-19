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

import { HttpResultMessageResultIEnumerableOrganizationDto } from '../model/httpResultMessageResultIEnumerableOrganizationDto';
import { HttpResultMessageResultOrganizationDto } from '../model/httpResultMessageResultOrganizationDto';
import { Request } from '../model/request';
import { Request1 } from '../model/request1';
import { Request2 } from '../model/request2';
import { Request3 } from '../model/request3';
 


@Injectable()
export class IOrganizationService {


    constructor(protected http:_HttpClient) {
    }


    /**
     * 创建组织机构
     * 
     * @param request 
* @param servicekey 
     */
    public create(request: Request, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultOrganizationDto>;
    public create(request: Request, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultOrganizationDto>>;
    public create(request: Request, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultOrganizationDto>>;
    public create(request: Request, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling create.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultOrganizationDto>(`/api/organization/create`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 删除组织机构
     * 
     * @param request 
* @param servicekey 
     */
    public delete(request: Request1, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultOrganizationDto>;
    public delete(request: Request1, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultOrganizationDto>>;
    public delete(request: Request1, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultOrganizationDto>>;
    public delete(request: Request1, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling delete.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultOrganizationDto>(`/api/organization/delete`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 根据Id获取组织机构
     * 
     * @param id 
* @param servicekey 
     */
    public getbyid(id: number, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultOrganizationDto>;
    public getbyid(id: number, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultOrganizationDto>>;
    public getbyid(id: number, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultOrganizationDto>>;
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


        return this.http.get<HttpResultMessageResultOrganizationDto>(`/api/organization/getbyid`,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 查询组织机构列表
     * 
     * @param request 
* @param servicekey 
     */
    public query(request: Request2, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultIEnumerableOrganizationDto>;
    public query(request: Request2, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultIEnumerableOrganizationDto>>;
    public query(request: Request2, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultIEnumerableOrganizationDto>>;
    public query(request: Request2, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling query.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultIEnumerableOrganizationDto>(`/api/organization/query`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 更新组织机构
     * 
     * @param request 
* @param servicekey 
     */
    public update(request: Request3, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultOrganizationDto>;
    public update(request: Request3, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultOrganizationDto>>;
    public update(request: Request3, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultOrganizationDto>>;
    public update(request: Request3, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling update.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultOrganizationDto>(`/api/organization/update`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

}
