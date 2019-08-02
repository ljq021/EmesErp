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

import { HttpResultMessageIEnumerablePostDto } from '../model/httpResultMessageIEnumerablePostDto';
import { HttpResultMessagePostDto } from '../model/httpResultMessagePostDto';
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
     * 
     * 
     * @param request 
* @param servicekey 
* @param authorization 
     */
    public create(request: Request4, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessagePostDto>;
    public create(request: Request4, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessagePostDto>>;
    public create(request: Request4, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessagePostDto>>;
    public create(request: Request4, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling create.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessagePostDto>(`/api/post/create`,
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
    public delete(request: Request5, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessagePostDto>;
    public delete(request: Request5, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessagePostDto>>;
    public delete(request: Request5, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessagePostDto>>;
    public delete(request: Request5, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling delete.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessagePostDto>(`/api/post/delete`,
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
    public getbyid(id: string, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessagePostDto>;
    public getbyid(id: string, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessagePostDto>>;
    public getbyid(id: string, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessagePostDto>>;
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


        return this.http.get<HttpResultMessagePostDto>(`/api/post/getbyid`,
            
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
    public query(request: Request6, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessageIEnumerablePostDto>;
    public query(request: Request6, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageIEnumerablePostDto>>;
    public query(request: Request6, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageIEnumerablePostDto>>;
    public query(request: Request6, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling query.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageIEnumerablePostDto>(`/api/post/query`,
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
    public update(request: Request7, servicekey?: any, authorization?: any, observe?: 'body'): Observable<HttpResultMessagePostDto>;
    public update(request: Request7, servicekey?: any, authorization?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessagePostDto>>;
    public update(request: Request7, servicekey?: any, authorization?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessagePostDto>>;
    public update(request: Request7, servicekey?: any, authorization?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling update.');
        }


        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessagePostDto>(`/api/post/update`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

}
