import { Routes } from '@angular/router';
import { ClientesListComponent } from './components/clientes/clientes-list/clientes-list.component';

export const routes: Routes = [
  { path: '', redirectTo: '/clientes', pathMatch: 'full' },
  { path: 'clientes', component: ClientesListComponent },
  { path: 'clientes/novo', component: ClientesListComponent },
  { path: 'clientes/:id/editar', component: ClientesListComponent },
  { path: 'planos', component: ClientesListComponent }, // Temporário até criarmos o componente de planos
  { path: 'assinaturas', component: ClientesListComponent }, // Temporário até criarmos o componente de assinaturas
];
