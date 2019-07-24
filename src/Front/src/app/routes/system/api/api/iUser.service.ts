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

import { HttpResultMessageResultIEnumerableUserDto } from '../model/httpResultMessageResultIEnumerableUserDto';
import { HttpResultMessageResultUserDto } from '../model/httpResultMessageResultUserDto';
import { HttpResultMessageUserDto } from '../model/httpResultMessageUserDto';
import { Request12 } from '../model/request12';
import { Request13 } from '../model/request13';
import { Request14 } from '../model/request14';
import { Request15 } from '../model/request15';
import { Request16 } from '../model/request16';
 


@Injectable({
  providedIn: 'root'
})
export class IUserService {


    constructor(protected http:_HttpClient) {
    }


    /**
     * 认证用户
     * 
     * @param request 
* @param servicekey 
     */
    public authentication(request: Request12, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageUserDto>;
    public authentication(request: Request12, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageUserDto>>;
    public authentication(request: Request12, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageUserDto>>;
    public authentication(request: Request12, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling authentication.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageUserDto>(`/api/user/authentication`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 创建用户领域模型
     * 
     * @param request 
* @param servicekey 
     */
    public create(request: Request13, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultUserDto>;
    public create(request: Request13, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultUserDto>>;
    public create(request: Request13, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultUserDto>>;
    public create(request: Request13, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling create.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultUserDto>(`/api/user/create`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 删除用户领域模型
     * 
     * @param request 
* @param servicekey 
     */
    public delete(request: Request14, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultUserDto>;
    public delete(request: Request14, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultUserDto>>;
    public delete(request: Request14, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultUserDto>>;
    public delete(request: Request14, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling delete.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultUserDto>(`/api/user/delete`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 根据Id获取用户领域模型
     * 
     * @param id 
* @param servicekey 
     */
    public getbyid(id: number, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultUserDto>;
    public getbyid(id: number, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultUserDto>>;
    public getbyid(id: number, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultUserDto>>;
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


        return this.http.get<HttpResultMessageResultUserDto>(`/api/user/getbyid`,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 查询用户领域模型列表
     * 
     * @param request 
* @param servicekey 
     */
    public query(request: Request15, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultIEnumerableUserDto>;
    public query(request: Request15, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultIEnumerableUserDto>>;
    public query(request: Request15, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultIEnumerableUserDto>>;
    public query(request: Request15, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling query.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultIEnumerableUserDto>(`/api/user/query`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 更新用户领域模型
     * 
     * @param request 
* @param servicekey 
     */
    public update(request: Request16, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultUserDto>;
    public update(request: Request16, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultUserDto>>;
    public update(request: Request16, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultUserDto>>;
    public update(request: Request16, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling update.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultUserDto>(`/api/user/update`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

}
