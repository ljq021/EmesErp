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

import { HttpResultMessageResultIEnumerablePostDto } from '../model/httpResultMessageResultIEnumerablePostDto';
import { HttpResultMessageResultPostDto } from '../model/httpResultMessageResultPostDto';
import { Request4 } from '../model/request4';
import { Request5 } from '../model/request5';
import { Request6 } from '../model/request6';
import { Request7 } from '../model/request7';
 


@Injectable({
  providedIn: 'root'
})
export class IPostService {


    constructor(protected http:_HttpClient) {
    }


    /**
     * 创建岗位
     * 
     * @param request 
* @param servicekey 
     */
    public create(request: Request4, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultPostDto>;
    public create(request: Request4, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultPostDto>>;
    public create(request: Request4, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultPostDto>>;
    public create(request: Request4, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling create.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultPostDto>(`/api/post/create`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 删除岗位
     * 
     * @param request 
* @param servicekey 
     */
    public delete(request: Request5, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultPostDto>;
    public delete(request: Request5, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultPostDto>>;
    public delete(request: Request5, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultPostDto>>;
    public delete(request: Request5, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling delete.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultPostDto>(`/api/post/delete`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 根据Id获取岗位
     * 
     * @param id 
* @param servicekey 
     */
    public getbyid(id: number, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultPostDto>;
    public getbyid(id: number, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultPostDto>>;
    public getbyid(id: number, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultPostDto>>;
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


        return this.http.get<HttpResultMessageResultPostDto>(`/api/post/getbyid`,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 查询岗位列表
     * 
     * @param request 
* @param servicekey 
     */
    public query(request: Request6, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultIEnumerablePostDto>;
    public query(request: Request6, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultIEnumerablePostDto>>;
    public query(request: Request6, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultIEnumerablePostDto>>;
    public query(request: Request6, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling query.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultIEnumerablePostDto>(`/api/post/query`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

    /**
     * 更新岗位
     * 
     * @param request 
* @param servicekey 
     */
    public update(request: Request7, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageResultPostDto>;
    public update(request: Request7, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultPostDto>>;
    public update(request: Request7, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultPostDto>>;
    public update(request: Request7, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling update.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters = queryParameters.set('servicekey', <any>servicekey);
        }


        return this.http.post<HttpResultMessageResultPostDto>(`/api/post/update`,
            request,
            {
                params: queryParameters,
                observe: observe,
            }
        );
    }

}
