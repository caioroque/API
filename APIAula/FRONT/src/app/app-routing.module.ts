import { CadastrarProdutoComponent } from './componets/views/produto/cadastrar-produto/cadastrar-produto.component';
import { ListarProdutoComponent } from './componets/views/produto/listar-produto/listar-produto.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
    {
        path:"",
        component: ListarProdutoComponent,
    },
    {
        path:"produto/listar",
        component: ListarProdutoComponent,
    },
    {
        path:"produto/cadastrar",
        component: CadastrarProdutoComponent,
    },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
