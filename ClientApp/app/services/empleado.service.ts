import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class EmpleadoService {

  constructor(private http: Http) { }

  getEmpleados() {
      return this.http.get('/api/empleados').map(res => res.json());
  }
}
