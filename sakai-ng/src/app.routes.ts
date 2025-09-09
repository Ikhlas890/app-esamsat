import { Routes } from '@angular/router';
import { AppLayout } from './app/layout/component/app.layout';
import { Dashboard } from './app/pages/dashboard/dashboard';
import { Documentation } from './app/pages/documentation/documentation';
import { Landing } from './app/pages/landing/landing';
import { Notfound } from './app/pages/notfound/notfound';
import { AuthGuard } from '@/guard/auth.guard';
import { NoAuthGuard } from '@/guard/no-auth.guard';

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
            { path: 'management-users', loadChildren: () => import('./app/pages/management-users/management-users.routes') },
            { path: 'setup', loadChildren: () => import('./app/pages/setup/setup.routes') },
            { path: 'uikit', loadChildren: () => import('./app/pages/uikit/uikit.routes') },
            { path: 'documentation', component: Documentation },
            { path: 'pages', loadChildren: () => import('./app/pages/pages.routes') }
        ]
    },
    { path: 'landing', component: Landing, canActivate: [NoAuthGuard] },
    { path: 'notfound', component: Notfound },
    {
        path: 'auth',
        canActivate: [NoAuthGuard], // Jika sudah login, redirect ke dashboard
        loadChildren: () => import('./app/pages/auth/auth.routes')
    },
    { path: '**', redirectTo: '/notfound' }
];
