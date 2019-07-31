import { Component, OnInit, Injector, ViewChild } from '@angular/core';
import { FormGroup, FormBuilder, Validators, FormControl, NgForm } from '@angular/forms';
import { BaseComponent } from '@layout/base.component';
import { Router } from '@angular/router';
import { IOrganizationService } from '../../api';
import { NotificationService } from '@core';

@Component({
  selector: 'emes-organization-list',
  templateUrl: './organization-list.component.html',
  styles: [],
})
export class OrganizationListComponent extends BaseComponent implements OnInit {
  @ViewChild('f', { static: false }) f: NgForm;
  nodes = [
    {
      title: '0-0',
      key: '00',
      expanded: true,
      children: [
        {
          title: '0-0-0',
          key: '000',
          expanded: true,
          children: [
            { title: '0-0-0-0', key: '0000', isLeaf: true },
            { title: '0-0-0-1', key: '0001', isLeaf: true },
            { title: '0-0-0-2', key: '0002', isLeaf: true },
          ],
        },
        {
          title: '0-0-1',
          key: '001',
          children: [
            { title: '0-0-1-0', key: '0010', isLeaf: true },
            { title: '0-0-1-1', key: '0011', isLeaf: true },
            { title: '0-0-1-2', key: '0012', isLeaf: true },
          ],
        },
        {
          title: '0-0-2',
          key: '002',
        },
      ],
    },
    {
      title: '0-1',
      key: '01',
      children: [
        {
          title: '0-1-0',
          key: '010',
          children: [
            { title: '0-1-0-0', key: '0100', isLeaf: true },
            { title: '0-1-0-1', key: '0101', isLeaf: true },
            { title: '0-1-0-2', key: '0102', isLeaf: true },
          ],
        },
        {
          title: '0-1-1',
          key: '011',
          children: [
            { title: '0-1-1-0', key: '0110', isLeaf: true },
            { title: '0-1-1-1', key: '0111', isLeaf: true },
            { title: '0-1-1-2', key: '0112', isLeaf: true },
          ],
        },
      ],
    },
    {
      title: '0-2',
      key: '02',
      isLeaf: true,
    },
  ];
  initialOrg = {
    ParentId: 0,
    No: '',
    Name: '',
    MnemonicCode: '',
    IsFiliale: false,
    IsSubbranch: false,
  };
  org;
  constructor(injector: Injector, private notifySrv: NotificationService, private orgSrv: IOrganizationService) {
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
    this.orgSrv.query({ request: {} }).subscribe(x => {
      console.log(x);
    });
  }

  add() {
    this.org = this.initialOrg;
  }
  edit($event) {
    this.org = $event;
  }
  save($event) {
    if (this.org.Id === undefined) {
      this.orgSrv.create({ request: this.org }).subscribe(x => {
        if (x.isSucceed) {
          this.reset();
        }
      });
    } else {
      this.orgSrv.update(this.org).subscribe(x => {
        if (x.isSucceed) {
          this.reset();
        }
      });
    }
  }
  delete($event) {
    if (this.org.Id !== undefined) {
      this.orgSrv.delete({ request: { id: this.org.Id } }).subscribe(x => {});
    } else {
      // this.edit();
    }
  }
}
