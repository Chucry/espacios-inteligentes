import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { ContactoComponent } from './components/contacto/contacto.component';
import { CounterComponent } from './components/counter/counter.component';
import { EmpleadoService } from './services/empleado.service';
import { EmpleadoComponent } from './components/empleado/empleado.component';

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        ContactoComponent,
        HomeComponent,
        EmpleadoComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'empleado', component: EmpleadoComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'contacto', component: ContactoComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [
        EmpleadoService
    ]
})
export class AppModuleShared {
}
