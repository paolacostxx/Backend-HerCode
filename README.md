# BackEndAPI

Esse é um projeto voltado para criação de uma interface que conecta a experiência do cliente da compra até a entrega do veículo. Este projeto demonstra o uso de DTOs, estrutura de camadas Controllers, Data, Models e configuração para Docker.

## Tecnologias e Ferramentas

Este projeto foi desenvolvido utilizando as seguintes tecnologias e ferramentas:

* **Linguagem:** C#
* **Framework:** .NET 8.0
* **Web Framework:** ASP.NET Core
* **Banco de Dados:** PostgreSQL
* **Mapeamento/ORM:** Entity Framework Core
* **Containers:** Docker
* **Ferramentas:** VS Code

---

##  Estrutura do Projeto

A estrutura do projeto segue um padrão de organização de camadas comum em projetos ASP.NET Core:

* **`Controllers/`**: Contém as classes que gerenciam as requisições HTTP (GET, POST, PUT, DELETE) e chamam a lógica de negócio.
* **`DTO/`**: (Data Transfer Objects) Contém classes usadas para transferir dados entre as camadas, garantindo a validação e a proteção contra *over-posting*.
* **`Models/`**: Contém as classes que representam as entidades de domínio e, geralmente, o esquema do banco de dados (se estiver usando EF Core).
* **`Data/`**: Contém a lógica de acesso a dados, como o `DbContext` do Entity Framework Core e configurações de banco de dados.
* **`appsettings.json` / `appsettings.Development.json`**: Arquivos de configuração da aplicação strings de conexão.
* **`Program.cs`**: Ponto de entrada da aplicação, onde o *host* e os serviços são configurados.
* **`docker-compose.yml`**: Arquivo para definir e executar a aplicação em contêineres Docker.

---

## ⚙️ Configuração e Execução

### Pré-requisitos

Segue abaixo as ferramentas que foram instaladas e usadas em nossas máquinas:

1.  **.NET SDK** ([Versão do .NET 8.0])
2.  **Git**
3.  **Docker** 

### 1. Clonar o Repositório

```bash
