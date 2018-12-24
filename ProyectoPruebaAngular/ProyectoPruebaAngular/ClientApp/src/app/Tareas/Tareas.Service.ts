import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { TareaModelAngular } from './TareaModel';


@Injectable()

export class TareasService {

  private rutaWebApi = this.baseUrl + "api/Tareas";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  obtenerTareas(): Observable<TareaModelAngular[]> {
    return this.http.get<TareaModelAngular[]>(this.rutaWebApi);
  }
}
