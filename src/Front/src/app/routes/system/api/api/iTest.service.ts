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

import { HttpResultMessageString } from '../model/httpResultMessageString';
import { Request12 } from '../model/request12';
 


@Injectable({
  providedIn: 'root'
})
export class ITestService {


    constructor(protected http:_HttpClient) {
    }


    /**
     * 
     * 
     * @param request 
* @param servicekey 
     */
    public get(request: Request12, servicekey?: any, observe?: 'body'): Observable<HttpResultMessageString>;
    public get(request: Request12, servicekey?: any, observe?: 'response'): Observable<HttpResponse<HttpResultMessageString>>;
    public get(request: Request12, servicekey?: any, observe?: 'events'): Observable<HttpEvent<HttpResultMessageString>>;
    public get(request: Request12, servicekey?: any, observe: any = 'body'): Observable<any> {

        if (request === null || request === undefined) {
            throw new Error('Required parameter request was null or undefined when calling get.');
        }

        const queryParameters:any = {};
  
        if (servicekey !== undefined && servicekey !== null) {
            queryParameters.servicekey = servicekey;
        }


        return this.http.post<HttpResultMessageString>(`/api/test/get`,
            request,
            
                 queryParameters,
    
            {
               
                observe,
            }
        );
    }

}
