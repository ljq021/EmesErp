import { NgModule } from '@angular/core';

import { UserRoutingModule } from './user-routing.module';
import { UserListComponent } from './user-list/user-list.component';
import { SharedModule } from '@shared';

@NgModule({
  declarations: [UserListComponent],
  imports: [SharedModule, UserRoutingModule],
})
export class UserModule {}
