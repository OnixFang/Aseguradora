import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ClienteListaComponent } from './cliente-lista/cliente-lista.component';
import { ClienteService } from './_services/cliente.service';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './login/auth.guard';
import { Rol } from './_models/rol.enum';
import { ClienteAddComponent } from './cliente-add/cliente-add.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        ClienteListaComponent,
        LoginComponent,
        ClienteAddComponent
    ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', component: HomeComponent, pathMatch: 'full', canActivate: [AuthGuard] },
            { path: 'clientes', component: ClienteListaComponent, canActivate: [AuthGuard], data: { roles: [Rol.Agente, Rol.Gerente, Rol.Supervisor] } },
            { path: 'add-cliente', component: ClienteAddComponent, canActivate: [AuthGuard], data: { roles: [Rol.Agente, Rol.Gerente, Rol.Supervisor] } },
            { path: 'login', component: LoginComponent },

            { path: '**', redirectTo: '' }
        ])
    ],
    providers: [ClienteService],
    bootstrap: [AppComponent]
})
export class AppModule { }
