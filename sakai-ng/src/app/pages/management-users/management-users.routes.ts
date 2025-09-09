import { Routes } from '@angular/router';
import { ManagementUser } from './management-user/management-user';
import { RegisterUser } from './register-user/register-user';
import { Appgroupuser } from './appgroupuser/appgroupuser';

export default [
    { path: 'manajemen-pengguna', component: ManagementUser },
    { path: 'register-user', component: RegisterUser },
    { path: 'kelompok-pengguna', component: Appgroupuser }
] as Routes;
