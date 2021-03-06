import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from '../_services/auth.service';

@Injectable({
    providedIn: 'root'
})
export class AuthGuard implements CanActivate {
    constructor(private auth: AuthService, private router: Router) { }

    canActivate(
        next: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        const currentuser = this.auth.currentUser();
        if (currentuser) {
            if (next.data.roles && next.data.roles.indexOf(currentuser.rol) === -1) {
                this.router.navigateByUrl("/");
                return true;
            }
            else {
                return true;
            }
        } else {
            this.router.navigateByUrl("/login");
            return false;
        }
    }
}
