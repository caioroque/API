import { HttpClientModule } from "@angular/common/http";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { AppRoutingModule } from "./app-routing.module";
// Imports dos componentes internos
import { AppComponent } from "./app.component";
import { CadastrarProdutoComponent } from "./componets/views/produto/cadastrar-produto/cadastrar-produto.component";
import { ListarProdutoComponent } from "./componets/views/produto/listar-produto/listar-produto.component";

@NgModule({
    declarations: [
        AppComponent,
        CadastrarProdutoComponent,
        ListarProdutoComponent,
    ],
    imports: [BrowserModule, AppRoutingModule, HttpClientModule, FormsModule],
    providers: [],
    bootstrap: [AppComponent],
})
export class AppModule {}