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

import { HttpResultMessageIEnumerableRoleDto } from '../model/httpResultMessageIEnumerableRoleDto';
import { HttpResultMessageRoleDto } from '../model/httpResultMessageRoleDto';
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
     * 
     * 
     * @param request 
* @param servicekey 
* @param authorization 
     */
    public create(request: Request8, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageRoleDto>;
    public create(request: Request8, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageRoleDto>>;
    public create(request: Request8, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageRoleDto>>;
    public create(request: Request8, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling create.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageRoleDto>(`/api/role/create`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

    /**
     * 
     * 
     * @param request 
* @param servicekey 
* @param authorization 
     */
    public delete(request: Request9, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageRoleDto>;
    public delete(request: Request9, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageRoleDto>>;
    public delete(request: Request9, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageRoleDto>>;
    public delete(request: Request9, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling delete.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageRoleDto>(`/api/role/delete`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

    /**
     * 
     * 
     * @param id 
* @param servicekey 
* @param authorization 
     */
    public getbyid(id: string, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageRoleDto>;
    public getbyid(id: string, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageRoleDto>>;
    public getbyid(id: string, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageRoleDto>>;
    public getbyid(id: string, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

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


        return this.http.get<HttpResultMessageRoleDto>(`/api/role/getbyid`,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

    /**
     * 
     * 
     * @param request 
* @param servicekey 
* @param authorization 
     */
    public query(request: Request10, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageIEnumerableRoleDto>;
    public query(request: Request10, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageIEnumerableRoleDto>>;
    public query(request: Request10, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageIEnumerableRoleDto>>;
    public query(request: Request10, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling query.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageIEnumerableRoleDto>(`/api/role/query`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

    /**
     * 
     * 
     * @param request 
* @param servicekey 
* @param authorization 
     */
    public update(request: Request11, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageRoleDto>;
    public update(request: Request11, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageRoleDto>>;
    public update(request: Request11, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageRoleDto>>;
    public update(request: Request11, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling update.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageRoleDto>(`/api/role/update`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

}
