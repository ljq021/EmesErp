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
* @param authorization 
     */
    public create(request: Request4, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultPostDto>;
    public create(request: Request4, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultPostDto>>;
    public create(request: Request4, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultPostDto>>;
    public create(request: Request4, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling create.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageResultPostDto>(`/api/post/create`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

    /**
     * 删除岗位
     * 
     * @param request 
* @param servicekey 
* @param authorization 
     */
    public delete(request: Request5, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultPostDto>;
    public delete(request: Request5, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultPostDto>>;
    public delete(request: Request5, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultPostDto>>;
    public delete(request: Request5, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling delete.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageResultPostDto>(`/api/post/delete`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

    /**
     * 根据Id获取岗位
     * 
     * @param id 
* @param servicekey 
* @param authorization 
     */
    public getbyid(id: number, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultPostDto>;
    public getbyid(id: number, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultPostDto>>;
    public getbyid(id: number, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultPostDto>>;
    public getbyid(id: number, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (id === null || id === undefined) {
            throw new Error('Required parameter id was null or undefined when calling getbyid.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }
        if (id !== undefined && id !== null) {
            queryParameters.id = id;
        }


        return this.http.get<HttpResultMessageResultPostDto>(`/api/post/getbyid`,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

    /**
     * 查询岗位列表
     * 
     * @param request 
* @param servicekey 
* @param authorization 
     */
    public query(request: Request6, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultIEnumerablePostDto>;
    public query(request: Request6, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultIEnumerablePostDto>>;
    public query(request: Request6, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultIEnumerablePostDto>>;
    public query(request: Request6, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling query.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageResultIEnumerablePostDto>(`/api/post/query`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

    /**
     * 更新岗位
     * 
     * @param request 
* @param servicekey 
* @param authorization 
     */
    public update(request: Request7, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultPostDto>;
    public update(request: Request7, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultPostDto>>;
    public update(request: Request7, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultPostDto>>;
    public update(request: Request7, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling update.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageResultPostDto>(`/api/post/update`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

}
