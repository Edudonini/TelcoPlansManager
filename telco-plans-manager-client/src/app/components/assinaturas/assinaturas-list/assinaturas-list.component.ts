import { Component, OnInit } from '@angular/core';
import { AssinaturasService } from '../../../services/assinaturas.service';
import { Assinatura } from '../../../models/assinatura.model';

@Component({
  selector: 'app-assinaturas-list',
  templateUrl: './assinaturas-list.component.html',
  styleUrls: ['./assinaturas-list.component.scss']
})
export class AssinaturasListComponent implements OnInit {
  assinaturas: Assinatura[] = [];

  constructor(private assinaturasService: AssinaturasService) { }

  ngOnInit(): void {
    this.loadAssinaturas();
  }

  loadAssinaturas(): void {
    this.assinaturasService.getAssinaturas()
      .subscribe({
        next: (data) => {
          this.assinaturas = data;
        },
        error: (error) => {
          console.error('Erro ao carregar assinaturas:', error);
        }
      });
  }
} 