import { Component, OnInit } from '@angular/core';
import { ClientesService } from '../../../services/clientes.service';
import { Cliente } from '../../../models/cliente.model';

@Component({
  selector: 'app-clientes-list',
  templateUrl: './clientes-list.component.html',
  styleUrls: ['./clientes-list.component.scss']
})
export class ClientesListComponent implements OnInit {
  clientes: Cliente[] = [];

  constructor(private clientesService: ClientesService) { }

  ngOnInit(): void {
    this.loadClientes();
  }

  loadClientes(): void {
    this.clientesService.getClientes()
      .subscribe({
        next: (data) => {
          this.clientes = data;
        },
        error: (error) => {
          console.error('Erro ao carregar clientes:', error);
        }
      });
  }
} 