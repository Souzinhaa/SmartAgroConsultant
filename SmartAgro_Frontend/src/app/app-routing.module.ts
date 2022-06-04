import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdubacaoComponent } from './adubacao/adubacao.component';
import { FuncionalidadeComponent } from './funcionalidade/funcionalidade.component';
import { LogarComponent } from './logar/logar.component';
import { LoginComponent } from './login/login.component';
import { MenuComponent } from './menu/menu.component';
import { ProdutividadeComponent } from './produtividade/produtividade.component';
import { ZoneamentoComponent } from './zoneamento/zoneamento.component';

const routes: Routes = [
  {
    path: "",
    component: LoginComponent
  },
  {
    path: "menu",
    component: MenuComponent
  },
  {
    path: "produtividade",
    component: ProdutividadeComponent
  },
  {
    path: "zoneamento",
    component: ZoneamentoComponent
  },
  {
    path: "funcionalidade",
    component: FuncionalidadeComponent
  },
  {
    path: "adubacao",
    component: AdubacaoComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
