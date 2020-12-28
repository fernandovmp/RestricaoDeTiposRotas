# Múltiplos *endpoints* em uma rota no ASP NET Core

Esse repositório contem o projeto de exemplo usado no artigo [Múltiplos *endpoints* em uma rota no ASP.NET Core](https://dev.to/fernandovmp/multiplos-endpoints-em-uma-rota-no-asp-net-core-1idg)

# Como rodar o projeto

### Clone

Primeiro clone o repositório

```
git clone https://github.com/fernandovmp/RestricaoDeTiposRotas
```

Então mova para o diretório do projeto

```
cd RestricaoDeTiposRotas
```

### Rodar

Requires

-   [.NET 5.0 SDK](https://dotnet.microsoft.com/download)

Restaure as dependências

```
dotnet restore
```

Faça o build do projeto com o comando

```
dotnet build
```

E execute com o seguinte comando

```
dotnet run
```

Acesse `http://localhost:5000/swagger`

O arquivo insomnia.json pode ser importado no insomnia e contem as requisições de exemplo
