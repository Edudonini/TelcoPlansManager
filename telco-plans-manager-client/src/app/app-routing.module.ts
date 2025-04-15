import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientesListComponent } from './components/clientes/clientes-list/clientes-list.component';
import { PlanosListComponent } from './components/planos/planos-list/planos-list.component';
import { AssinaturasListComponent } from './components/assinaturas/assinaturas-list/assinaturas-list.component';

const routes: Routes = [
  { path: '', redirectTo: '/clientes', pathMatch: 'full' },
  { path: 'clientes', component: ClientesListComponent },
  { path: 'planos', component: PlanosListComponent },
  { path: 'assinaturas', component: AssinaturasListComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { } 