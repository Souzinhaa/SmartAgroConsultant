import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {CardModule} from 'primeng/card';
import {ButtonModule} from 'primeng/button';
import { MenuComponent } from './menu/menu.component';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { LogarComponent } from './logar/logar.component';
import {AccordionModule} from 'primeng/accordion';
import {MenuItem} from 'primeng/api'; 
import {PasswordModule} from 'primeng/password';
import {MenuModule} from 'primeng/menu';
import {DividerModule} from 'primeng/divider';
import {InputTextModule} from 'primeng/inputtext';
import { FuncoesComponent } from './funcoes/funcoes.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { ProdutividadeComponent } from './produtividade/produtividade.component';
import { ZoneamentoComponent } from './zoneamento/zoneamento.component';
import { FuncionalidadeComponent } from './funcionalidade/funcionalidade.component';
import { LinhaComponent } from './linha/linha.component';
import { AdubacaoComponent } from './adubacao/adubacao.component';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    LoginComponent,
    LogarComponent,
    FuncoesComponent,
    HeaderComponent,
    FooterComponent,
    ProdutividadeComponent,
    ZoneamentoComponent,
    FuncionalidadeComponent,
    LinhaComponent,
    AdubacaoComponent
  ],
  imports: [
    PasswordModule,
    MenuModule,
    DividerModule,
    AccordionModule,
    BrowserAnimationsModule,
    CardModule,
    InputTextModule,
    ButtonModule,
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
