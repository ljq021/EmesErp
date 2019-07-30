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
     * 
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

        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageUserDto>(`/api/user/authentication`,
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
    public create(request: Request13, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultUserDto>;
    public create(request: Request13, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultUserDto>>;
    public create(request: Request13, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultUserDto>>;
    public create(request: Request13, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling create.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageResultUserDto>(`/api/user/create`,
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
    public delete(request: Request14, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultUserDto>;
    public delete(request: Request14, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultUserDto>>;
    public delete(request: Request14, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultUserDto>>;
    public delete(request: Request14, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling delete.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageResultUserDto>(`/api/user/delete`,
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
    public getbyid(id: number, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultUserDto>;
    public getbyid(id: number, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultUserDto>>;
    public getbyid(id: number, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultUserDto>>;
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


        return this.http.get<HttpResultMessageResultUserDto>(`/api/user/getbyid`,
            
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
    public query(request: Request15, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultIEnumerableUserDto>;
    public query(request: Request15, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultIEnumerableUserDto>>;
    public query(request: Request15, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultIEnumerableUserDto>>;
    public query(request: Request15, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling query.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageResultIEnumerableUserDto>(`/api/user/query`,
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
    public update(request: Request16, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageResultUserDto>;
    public update(request: Request16, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageResultUserDto>>;
    public update(request: Request16, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageResultUserDto>>;
    public update(request: Request16, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling update.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageResultUserDto>(`/api/user/update`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

}
