import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClientesListComponent } from './components/clientes/clientes-list/clientes-list.component';
import { PlanosListComponent } from './components/planos/planos-list/planos-list.component';
import { AssinaturasListComponent } from './components/assinaturas/assinaturas-list/assinaturas-list.component';

@NgModule({
  declarations: [
    AppComponent,
    ClientesListComponent,
    PlanosListComponent,
    AssinaturasListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { } 