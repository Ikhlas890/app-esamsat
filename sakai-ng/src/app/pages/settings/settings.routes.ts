import { Routes } from '@angular/router';
import { ManagementUser } from './management-user/management-user';
import { RegisterUser } from './register-user/register-user';

export default [
    { path: 'management-user', component: ManagementUser },
    { path: 'register-user', component: RegisterUser },
    { path: '**', redirectTo: '/notfound' }
] as Routes;
