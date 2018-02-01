import { Component, Inject, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { EmpleadoService } from '../../services/empleado.service';

@Component({
    selector: 'empleado',
    templateUrl: './empleado.component.html'
})
export class EmpleadoComponent {
    empleados;

    constructor(private empleadoService: EmpleadoService) { }

    ngOnInit() {
        this.empleadoService.getEmpleados().subscribe(empleados => 
            this.empleados = empleados);        
    }

    agregarEmpleado() {
        
    }
}