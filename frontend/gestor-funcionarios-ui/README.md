# Gestor de Funcionários

> **Sobre o Projeto:** Este sistema Full-Stack foi construído passo a passo do zero como parte prática de um curso do canal **CrisTech20** no YouTube. O projeto engloba tanto o desenvolvimento da API RESTful no backend (C#) quanto a criação e integração da interface moderna no frontend (Angular).

## 🚀 Tecnologias Utilizadas

**Frontend**
* Angular
* TypeScript
* Angular Material (MatTable, MatCard, MatDialog, MatInput, MatSelect)
* Reactive Forms

**Backend**
* ASP.NET 8 Web API (C#)
* Entity Framework Core
* SQL Server

## ✨ Funcionalidades Implementadas

O sistema foi estruturado para realizar o CRUD completo, com o frontend consumindo os endpoints da nossa própria API:

* **Tabela Dinâmica e Filtro:** Listagem de todos os registros utilizando `mat-table`, com um campo de busca que filtra os funcionários em tempo real conforme a digitação.
* **Formulário Reutilizável:** Criação do componente isolado `app-funcionario-form`, que é reaproveitado dinamicamente tanto para a página de **Cadastro** quanto para a de **Edição**, utilizando diretivas `@Input` e `@Output`.
* **Validação em Tempo Real:** Uso de Reactive Forms para garantir que dados obrigatórios (nome, departamento, turno, etc.) sejam preenchidos antes de liberar o botão de envio.
* **Leitura e Inativação:** Página de Detalhes (`/detalhes/:id`) com inputs desabilitados para leitura, formatação automática de datas para o padrão brasileiro e botão de ação para alternar o status do colaborador para "Inativo".
* **Modal de Exclusão Segura:** Integração com o `MatDialog` para abrir um modal de confirmação de exclusão (`ExcluirComponent`). A exclusão só ocorre no banco de dados após a confirmação, atualizando a listagem automaticamente.
