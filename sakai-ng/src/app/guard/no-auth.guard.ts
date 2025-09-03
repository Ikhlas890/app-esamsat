import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '../services/auth.service';
import { Observable, of } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class NoAuthGuard implements CanActivate {
  constructor(private authService: AuthService, private router: Router) {}

  canActivate(): Observable<boolean> {
    return this.authService.getLoggedUser().pipe(
      map((res) => {
        // Jika sudah login, arahkan ke dashboard
        this.router.navigate(['/dashboard']);
        return false;
      }),
      catchError(() => {
        // Jika belum login, izinkan akses
        return of(true);
      })
    );
  }
}
