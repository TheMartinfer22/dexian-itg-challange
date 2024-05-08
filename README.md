# Dexian ITG Challange

Esta documentação fornece instruções de inicialização, ferramentas utilizadas e os endpoints disponíveis na aplicação.

## Instruções de Inicialização

Para iniciar a aplicação, siga os passos abaixo:

1. Certifique-se de ter o .NET Core instalado em sua máquina.
2. Clone o repositório do GitHub para sua máquina local.
3. Navegue até o diretório raiz da aplicação.
4. Execute o comando `dotnet run` para iniciar a aplicação.
5. A aplicação estará disponível em `http://localhost:5290`.

## Ferramentas Utilizadas

- ASP.NET Core: Framework utilizado para construir a aplicação REST.
- C#: Linguagem de programação utilizada para desenvolver a lógica da aplicação.
- Jetbrains Rider

## Endpoints

A seguir estão os endpoints disponíveis na aplicação:

### Escolas

#### GET /api/v1/escolas

Retorna uma lista de todas as escolas.

#### GET /api/v1/escolas/{id}

Retorna uma escola específica com base no ID fornecido.

#### POST /api/v1/escolas

Adiciona uma nova escola.

#### PUT /api/v1/escolas/{id}

Atualiza os dados de uma escola existente com base no ID fornecido.

#### DELETE /api/v1/escolas/{id}

Remove uma escola com base no ID fornecido.

### Alunos

#### GET /api/v1/alunos

Retorna uma lista de todos os alunos.

#### GET /api/v1/alunos/{id}

Retorna um aluno específico com base no ID fornecido.

#### POST /api/v1/alunos

Adiciona um novo aluno.

#### PUT /api/v1/alunos/{id}

Atualiza os dados de um aluno existente com base no ID fornecido.

#### DELETE /api/v1/alunos/{id}

Remove um aluno com base no ID fornecido.

