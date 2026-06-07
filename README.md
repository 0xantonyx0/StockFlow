# StockFlow

> **Status:** 🚧 Em Desenvolvimento

O **StockFlow** é um sistema de gerenciamento de estoque desktop desenvolvido em **C#** com **WPF** (Windows Presentation Foundation). O projeto foca na manipulação eficiente de planilhas de dados no formato `.ods` (OpenDocument Spreadsheet) utilizando a biblioteca **Aspose.Cells**.

Atualmente, o projeto possui uma estrutura simplificada: classes de dados em `Models` e as telas da aplicação (páginas/janelas) organizadas diretamente, com a lógica de carregamento de dados implementada para converter planilhas em objetos.

![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![License](https://img.shields.io/badge/license-MIT-blue)

## 🎯 Objetivos

- Desenvolver uma aplicação desktop leve para gestão de estoque.
- Garantir compatibilidade nativa com o formato `.ods` sem dependências do Microsoft Excel.
- Organizar os dados de estoque em classes dedicadas (`Models`) para fácil manipulação.
- Implementar uma navegação fluida entre as telas da aplicação.

## 🛠️ Tecnologias e Dependências

| Tecnologia | Função |
|------------|--------|
| **C# / .NET** | Linguagem e Framework base |
| **WPF** | Interface Gráfica (UI) e Navegação |
| **Aspose.Cells** | Manipulação de planilhas `.ods` (Leitura/Escrita) |
| **XAML** | Design da interface e layout |

## 📦 Funcionalidades (Estado Atual)

- [x] **Estrutura do Projeto**: Configuração inicial da solução.
- [x] **Modelos de Dados**: Classes em `Models` definindo a estrutura do estoque (ex: `Produto`).
- [x] **Navegação**: Sistema de páginas e transições implementado.
- [x] **Carregamento de Dados**: Método funcional para ler arquivos `.ods` e popular objetos C#.
- [ ] **Exibição na UI**: Integração dos dados carregados com `DataGrid` ou controles de listagem.
- [ ] **Edição e Persistência**: Funcionalidades para alterar dados e salvar de volta no `.ods`.

## 🏗️ Arquitetura Atual

O projeto segue uma estrutura direta e minimalista, ideal para o desenvolvimento ágil da fase inicial:

- **Models**: Pasta contendo as classes que representam os dados do negócio (ex: `Produto.cs`). São as entidades que recebem os dados da planilha.
- **Telas (Pages/Windows)**: Os arquivos `.xaml` e seus códigos-behind (`.xaml.cs`) que compõem a interface. A lógica de carregamento, navegação e manipulação inicial reside diretamente nestes arquivos ou em métodos auxiliares próximos.
- **App.xaml**: Ponto de entrada e configuração global da aplicação.

> **Nota:** Não há camadas intermediárias complexas (como ViewModels ou Serviços separados) nesta fase. A interação com o **Aspose.Cells** ocorre diretamente no código das telas ou em métodos estáticos auxiliares, mantendo o código simples e fácil de entender.
