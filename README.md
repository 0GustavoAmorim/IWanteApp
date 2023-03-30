
# IWantApp

Uma projeto de API desenvolvida em .NET 6, Entity Framework, Identity, SQL Server, JWT e Autenticação para estudos.
Trata-se de uma API para um Ecommerce fictício, onde é possível realizar todas as operações de CRUD em Products, Categories, Clients, Employees, Orders.



## Rodando localmente
Ainda não tenho como hospedar, então fica aqui como rodar localmente.

Clone o projeto

```bash
  git clone https://github.com/0GustavoAmorim/IWanteApp.git
```

Entre no diretório do projeto

```bash
  cd IWantApp
```

Instale as dependências
dotnet tool install --global dotnet-ef
```bash
  dotnet tool install --global dotnet-ef
```
```bash
  dotnet add package Microsoft.EntityFrameworkCore
```
```bash
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
```bash
  dotnet add package Microsoft.EntityFrameworkCore.Design
```
```bash
  Microsoft.AspNetCore.Identity.EntityFrameworkCore
```
```bash
  dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
```
```bash
  dotnet add package Serilog.AspNetCore
```
```bash
  dotnet add package Serilog.Sinks.MSSqlServer
```
```bash
  dotnet add package Swashbuckle.AspNetCore
```
```bash
  dotnet add package Dapper
```
```bash
  dotnet add package Flunt
```


Inicie o servidor

```bash
  npm run start
```


## String de Conexão

Por motivos de segurança não subi o código com a ConnectionString do meu banco.

Para rodar o projeto localmente em sua máquina, adicione a sua ConnectionString no arquivo

```bash
  appsettings.Development.json
```


## Screenshots

![ConnectionString](https://user-images.githubusercontent.com/89614046/228942312-09972594-b2f6-443d-a74c-03ac52013930.png)


E rode a Migration para criação das tabelas no seu banco de dados SQL Server usando o seguinte comando no terminal:

```bash
  dotnet ef migrations add InitialMigration
```
Esse comando criara as migrations usando o Entity FrameworkCore.

### Atualizar database
Agora para subir a Migration de fato para o banco, rode o seguinte comando: 

```bash
  dotnet ef database update
```
Agora ja está tudo pronto para fazer as requisições, recomendo usar o Postman.

Rode projeto utilizando o comando no terminal:
```bash
  dotnet watch run
```


