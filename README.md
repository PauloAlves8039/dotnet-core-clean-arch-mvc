<h1 align="center">CleanArchMvc</h1>

## :computer: Projeto

Repositório de uma aplicação web para exemplificar o uso de arquitetura em camadas utilizando conceitos do [Clean Architecture](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html), 
código fonte do projeto foi baseado no curso [Clean Architecture Essencial - ASP .NET Core com C#](https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/).

Essa aplicação dispôe de um catálago com funcionalidades para inserir, buscar, atualziar e excluir registros em um relacionamento do tipo 1:N (um para muitos)
onde uma categoria possui vários produtos, mas um produto só pertence a uma categoria. 

Foi implementado recursos para autenticação de usuários na aplicação com o [ASP .NET Core Identity](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio), onde é possível adicionar novos usuários para realizar seus respectivos acessos através de credenciais.

## :wrench: Recursos Utilizados

- [Visual Studio v16.9.5](https://visualstudio.microsoft.com/pt-br/)
- [ASP.NET Core MVC v5.0.203](https://dotnet.microsoft.com/download/dotnet/5.0)
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/getting-started/)
- [Entity Framework Core v5.0.7](https://docs.microsoft.com/pt-br/ef/core/)
- [SQL Server v18.8](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [AutoMapper v10.1.1](https://automapper.org/)
- [Identity v2.2.0](https://docs.microsoft.com/pt-br/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio)

## :floppy_disk: Clonar Repositório

`git clone https://github.com/PauloAlves8039/dotnet-core-clean-arch-mvc.git`

- Abra a pasta ```dotnet-core-clean-arch-mvc``` no prompt de comando.
- Execute ```dotnet restore``` para restaurar as dependências e ferramentas do projeto.

## :camera: Diagrama do Banco de Dados

<p align="center"> <img src="https://github.com/PauloAlves8039/dotnet-core-clean-arch-mvc/blob/master/CleanArchMvc.WebUI/wwwroot/images/diagrama.png" /></p>
Diagrama gerado no Microsoft SQL Server management Studio para exibir a estrutura da base de dados implementada no projeto.

## Author

:boy: [Paulo Alves](https://github.com/PauloAlves8039)
