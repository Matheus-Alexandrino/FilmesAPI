🎬 Projeto de Estudo: API de Filmes com .NET 9, Docker e Swagger
Este projeto é uma aplicação de estudo desenvolvida com base nos cursos da Alura. Ele apresenta uma API REST de filmes utilizando .NET 9, com documentação interativa via Swagger e containerização via Docker.
📚 Tecnologias Utilizadas
- .NET 9
- ASP.NET Core Web API
- Swagger / Swashbuckle
- Docker
- Entity Framework Core (opcional para persistência)
🚀 Como Executar o Projeto
Pré-requisitos
- .NET 9 SDK
- Docker Desktop
- Git instalado

Clonando o Repositório:
git clone https://github.com/seu-usuario/nome-do-repositorio.git
cd nome-do-repositorio

Executando com Docker:
docker build -t filmes-api .
docker run -p 5000:80 filmes-api

A API estará disponível em: http://localhost:5000/swagger
🛠️ Endpoints Principais
| Verbo HTTP | Endpoint | Descrição | 
| GET | /api/filmes | Lista todos os filmes | 
| GET | /api/filmes/{id} | Retorna um filme pelo ID | 
| POST | /api/filmes | Cria um novo filme | 
| PUT | /api/filmes/{id} | Atualiza os dados de um filme | 
| DELETE | /api/filmes/{id} | Remove um filme | 

📄 Documentação da API
A documentação da API é gerada automaticamente via Swagger e pode ser acessada após subir a aplicação:
👉 http://localhost:5000/swagger
🧪 Testes
(Adicione uma seção se você incluir testes unitários ou de integração.)
🧠 Aprendizados
Este projeto reforça conceitos como:
- Criação de APIs com boas práticas RESTful
- Versionamento de APIs
- Containerização de apps .NET com Docker
- Uso de Swagger para documentação interativa
📦 Contribuindo
Pull requests são bem-vindos. Para mudanças maiores, por favor abra uma issue primeiro para discutir o que você gostaria de modificar




