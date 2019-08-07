import { Component, OnInit, Injector, ViewChild } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl, NgForm } from '@angular/forms';
import { BaseComponent } from '@layout/base.component';
import { Router } from '@angular/router';
import { IOrganizationService } from '../../api';
import { NotificationService, ArrayService } from '@core';

@Component({
  selector: 'emes-organization-list',
  templateUrl: './organization-list.component.html',
  styles: [],
})
export class OrganizationListComponent extends BaseComponent implements OnInit {
  @ViewChild('f', { static: false }) f: NgForm;
  nodes = [];
  selectNodes = [];
  initialOrg = {
    parentId: '',
    no: '',
    name: '',
    mnemonicCode: '',
    isFiliale: false,
    isSubbranch: false,
  };
  org;
  constructor(
    injector: Injector,
    private notifySrv: NotificationService,
    private arrSrv: ArrayService,
    private orgSrv: IOrganizationService,
  ) {
    super(injector);
  }
  ngOnInit() {
    this.org = this.initialOrg;
    this.getList();
  }
  reset() {
    this.f.reset();
  }
  getList() {
    this.orgSrv.query({ request: {} }).subscribe((x: any) => {
      if (!x) return;
      this.nodes = this.arrSrv.arrToTreeNode(x, {
        parentIdMapName: 'parentId',
        titleMapName: 'name',
      });
      this.selectNodes = this.arrSrv.arrToTreeNode(x, {
        parentIdMapName: 'parentId',
        titleMapName: 'name',
      });
    });
  }

  add($event) {
    this.org = this.initialOrg;
  }
  addChild($event) {
    const pid = this.org.id;
    this.org = this.initialOrg;
    this.org.parentId = pid;
  }
  edit($event) {
    this.org = $event.node.origin;
  }
  save($event) {
    if (this.org.id === undefined) {
      this.orgSrv.create({ request: this.org }).subscribe(x => {
        this.notifySrv.success();
        this.getList();
        this.reset();
      });
    } else {
      this.orgSrv.update(this.org).subscribe(x => {
        this.notifySrv.success();
        this.getList();
        this.reset();
      });
    }
  }
  delete($event) {
    if (this.org.id !== undefined) {
      this.orgSrv.delete({ request: { id: this.org.id } }).subscribe(x => {
        this.notifySrv.success();
        this.reset();
        this.getList();
      });
    } else {
      this.notifySrv.info('请选择需要删除的记录！');
    }
  }
}
