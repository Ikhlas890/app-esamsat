import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '../services/auth.service';
import { Observable, of } from 'rxjs';
import { catchError, map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authService: AuthService, private router: Router) {}

  canActivate(): Observable<boolean> {
    return this.authService.getLoggedUser().pipe(
      map((res) => {
        // Jika user terautentikasi
        return true;
      }),
      catchError(() => {
        // Jika tidak ada session atau gagal ambil data user
        this.router.navigate(['/auth/login']);
        return of(false);
      })
    );
  }
}
