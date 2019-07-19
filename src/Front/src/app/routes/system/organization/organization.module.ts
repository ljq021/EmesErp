import { NgModule } from '@angular/core';

import { OrganizationRoutingModule } from './organization-routing.module';
import { OrganizationListComponent } from './organization-list/organization-list.component';
import { OrganizationCreatComponent } from './organization-creat/organization-creat.component';
import { SharedModule } from '@shared';

@NgModule({
  declarations: [OrganizationListComponent, OrganizationCreatComponent],
  imports: [SharedModule, OrganizationRoutingModule],
})
export class OrganizationModule {}
