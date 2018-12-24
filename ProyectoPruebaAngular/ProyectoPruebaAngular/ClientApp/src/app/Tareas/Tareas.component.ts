import { Component, OnInit } from '@angular/core';
import { TareaModelAngular } from './TareaModel';
import { TareasService } from './Tareas.Service';

@Component({
  selector: 'app-tareas',
  templateUrl: './tareas.component.html',
})

export class TareasComponent {
  tareas: TareaModelAngular[];

  constructor(private servicioDeTareas: TareasService) { }

  ngOnInit() {
    this.servicioDeTareas.obtenerTareas().subscribe(t => this.tareas = t,
      error => console.error(error));
  }
}
