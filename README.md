<h1 align="center">CleanArchMvc</h1>

## :computer: Projeto

Repositório de uma aplicação web para exemplificar o uso de arquitetura em camadas utilizando conceitos do [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html),
código fonte do projeto foi baseado no curso [Clean Architecture Essencial - ASP .NET Core com C#](https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/).

Essa aplicação dispõe de um catálago com funcionalidades para  `inserir`, `buscar`, `atualizar` e `excluir` registros em um relacionamento do tipo `1:N` (um para muitos)
onde uma `Categoria` possui vários `Produtos`, mas um `Produto` só pertence a uma  `Categoria`.

Usando o [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/) e os recursos do [Code First Migrations](https://docs.microsoft.com/pt-br/ef/ef6/modeling/code-first/migrations/) foram realizadas essas implementações na base de dados criada com o 
[SQL Server 2019](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).

Foram implementados recursos para `Autenticação` e `Autorização` de usuários na aplicação com o [ASP .NET Core Identity](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio), onde é possível adicionar novos usuários para realizar seus respectivos acessos através de credenciais.

Em todas as `Views` foram utilizados componentes do [Bootstrap](https://getbootstrap.com/), com o objetivo de aplicar estilos [CSS](https://getbootstrap.com/) para uma melhor experiência do usuário na iteração com os elementos de telas na aplicação.

A principio foram realizados testes de unidade com o [XUnit](https://xunit.net/) e [FluentAssertions](https://fluentassertions.com/) para as entidades `Categoria` e  `Produtos`, 
que tiveram validações implementadas em suas respectivas classes usando o conceito de domínios ricos e tratamento de exceções.

## :wrench: Recursos Utilizados

- [Visual Studio v16.9.5](https://visualstudio.microsoft.com/pt-br/)
- [ASP.NET Core MVC v5.0.203](https://dotnet.microsoft.com/download/dotnet/5.0)
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/getting-started/)
- [Entity Framework Core v5.0.7](https://docs.microsoft.com/pt-br/ef/core/)
- [SQL Server v18.8](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [AutoMapper v10.1.1](https://automapper.org/)
- [Identity v2.2.0](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio)
- [XUnit v2.4.1](https://xunit.net/)
- [FluentAssertions v5.10.3](https://fluentassertions.com/)
- [Bootstrap v4.3.1](https://getbootstrap.com/)

## :floppy_disk: Clonar Repositório

`git clone https://github.com/PauloAlves8039/dotnet-core-clean-arch-mvc.git`

- Abra a pasta `dotnet-core-clean-arch-mvc` no prompt de comando.
- Execute `dotnet restore` para restaurar as dependências e ferramentas do projeto.

## :camera: Screenshots

### Diagrama do Banco de Dados

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-clean-arch-mvc/blob/master/CleanArchMvc.WebUI/wwwroot/images/diagrama.png" /></p>

### Login

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-clean-arch-mvc/blob/master/CleanArchMvc.WebUI/wwwroot/images/screenshot1.png" /></p>

### Lista de Categorias

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-clean-arch-mvc/blob/master/CleanArchMvc.WebUI/wwwroot/images/screenshot2.png" /></p>

### Lista de Produtos

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-clean-arch-mvc/blob/master/CleanArchMvc.WebUI/wwwroot/images/screenshot3.png" /></p>

## Author

:boy: [Paulo Alves](https://github.com/PauloAlves8039)
