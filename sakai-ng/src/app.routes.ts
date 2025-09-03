import { Routes } from '@angular/router';
import { AppLayout } from './app/layout/component/app.layout';
import { Dashboard } from './app/pages/dashboard/dashboard';
import { Documentation } from './app/pages/documentation/documentation';
import { Landing } from './app/pages/landing/landing';
import { Notfound } from './app/pages/notfound/notfound';
import { AuthGuard } from '@/guard/auth.guard';
import { NoAuthGuard } from '@/guard/no-auth.guard';
import { ManagementUser } from '@/pages/settings/management-user/management-user';
import { RegisterUser } from '@/pages/settings/register-user/register-user';
import { Appgroupuser } from '@/pages/settings/appgroupuser/appgroupuser';

export const appRoutes: Routes = [
    {
        path: '',
        redirectTo: '/landing',
        pathMatch: 'full'
    },
    {
        path: '',
        component: AppLayout,
        canActivate: [AuthGuard], // Semua child di bawahnya butuh login
        children: [
            { path: 'dashboard', component: Dashboard },
            { path: 'management-user', component: ManagementUser },
            { path: 'register-user', component: RegisterUser },
            { path: 'kelompok-user', component: Appgroupuser },
            { path: 'uikit', loadChildren: () => import('./app/pages/uikit/uikit.routes') },
            { path: 'documentation', component: Documentation },
            { path: 'pages', loadChildren: () => import('./app/pages/pages.routes') }
        ]
    },
    { path: 'landing', component: Landing },
    { path: 'notfound', component: Notfound },
    {
        path: 'auth',
        canActivate: [NoAuthGuard], // Jika sudah login, redirect ke dashboard
        loadChildren: () => import('./app/pages/auth/auth.routes')
    },
    { path: '**', redirectTo: '/notfound' }
];
