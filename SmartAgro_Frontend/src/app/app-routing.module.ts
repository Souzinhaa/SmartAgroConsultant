import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdubacaoComponent } from './adubacao/adubacao.component';
import { CriarcontaComponent } from './criarconta/criarconta.component';
import { FuncionalidadeComponent } from './funcionalidade/funcionalidade.component';
import { LogarComponent } from './logar/logar.component';
import { MenuComponent } from './menu/menu.component';
import { PerfilComponent } from './perfil/perfil.component';
import { ProdutividadeComponent } from './produtividade/produtividade.component';
import { ZoneamentoComponent } from './zoneamento/zoneamento.component';

const routes: Routes = [
  {
    path: "",
    component: LogarComponent
  },
  /*{
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
  {
    path: "perfil",
    component: PerfilComponent
  },*/
  {
    path: "criarconta",
    component: CriarcontaComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
