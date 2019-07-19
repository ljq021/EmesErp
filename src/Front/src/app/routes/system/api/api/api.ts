export * from './iOrganization.service';
import { IOrganizationService } from './iOrganization.service';
export * from './iPost.service';
import { IPostService } from './iPost.service';
export * from './iRole.service';
import { IRoleService } from './iRole.service';
export * from './iUser.service';
import { IUserService } from './iUser.service';
export const APIS = [IOrganizationService, IPostService, IRoleService, IUserService];
