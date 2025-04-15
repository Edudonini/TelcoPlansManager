import { Component, OnInit } from '@angular/core';
import { PlanosService } from '../../../services/planos.service';
import { Plano } from '../../../models/plano.model';

@Component({
  selector: 'app-planos-list',
  templateUrl: './planos-list.component.html',
  styleUrls: ['./planos-list.component.scss']
})
export class PlanosListComponent implements OnInit {
  planos: Plano[] = [];

  constructor(private planosService: PlanosService) { }

  ngOnInit(): void {
    this.loadPlanos();
  }

  loadPlanos(): void {
    this.planosService.getPlanos()
      .subscribe({
        next: (data) => {
          this.planos = data;
        },
        error: (error) => {
          console.error('Erro ao carregar planos:', error);
        }
      });
  }
} 