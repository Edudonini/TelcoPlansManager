# TelcoPlansManager
Sistema de Gerenciamento de Planos e Clientes Telecom (Full Stack .NET + Angular + SQL Server).

## 🚀 Tecnologias Utilizadas

### Backend
- .NET 8.0
- Entity Framework Core
- SQL Server
- Swagger/OpenAPI

### Frontend
- Angular 19
- Angular Material
- Bootstrap 5
- TypeScript

## 📋 Funcionalidades Implementadas

### Módulo de Clientes
- [x] Listagem de clientes com paginação
- [x] Filtro de busca por nome
- [x] Ações de editar e excluir cliente
- [x] Interface responsiva com Material Design

### Próximos Passos
- [ ] Formulário de cadastro/edição de clientes
- [ ] Módulo de Planos
- [ ] Módulo de Assinaturas
- [ ] Relatórios e dashboards

## 🛠️ Como Executar

### Backend
1. Clone o repositório
2. Navegue até a pasta da API:
```bash
cd TelcoPlansManager.API
```
3. Restaure os pacotes:
```bash
dotnet restore
```
4. Execute a API:
```bash
dotnet run
```
5. Acesse o Swagger em: `http://localhost:5207/swagger`

### Frontend
1. Navegue até a pasta do cliente:
```bash
cd telco-plans-manager-client
```
2. Instale as dependências:
```bash
npm install
```
3. Execute o projeto:
```bash
ng serve
```
4. Acesse a aplicação em: `http://localhost:4200`

## 📝 Estrutura do Projeto

### Backend
- `Controllers/`: Endpoints da API
- `Entities/`: Modelos de domínio
- `Data/`: Contexto do Entity Framework e configurações
- `Migrations/`: Migrações do banco de dados

### Frontend
- `src/app/components/`: Componentes Angular
- `src/app/services/`: Serviços para comunicação com a API
- `src/app/models/`: Interfaces TypeScript
- `src/app/environments/`: Configurações de ambiente

## 🤝 Contribuindo
1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📄 Licença
Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
