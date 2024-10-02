# Documentação
#4

## About

### Application
A aplicação basea-se em um Menu de visualização da própria documentação/TimeLine do projeto. O mesmo mostrará as opções para percorrer o histório do inicio ao fim do projeto.

### Tools
Utilizar a IDE Visual Studio 2022

### Dependencies
Baixe e instale o SDK do .NET Core 8.0, que é compatível com C# 8.0 https://dotnet.microsoft.com/pt-br/download/dotnet/8.0
Baixe e instale https://visualstudio.microsoft.com/pt-br/downloads/

### Run
Após instalar todas dependencias, acessar a pasta ProjetoConsole e abrir o arquivo ProjetoConsole.sln no Visual Studio. Para executar o projeto em modo de depuração aperte F5, para executar sem depuração aperte Ctrl + F5

## Rules

### Processos
Deverá ser criado uma branch para cada funcionalidade (issue) baseada na última versão da develop do servidor remoto (github). Após a conclusão do desenvolvimento da mesma será feito um commit destacando no título o número da Issue correspondente. Quando bem sucedido o proximo passo será gerar um Pull Request para a branch develop para merge e então um git command "Pull" na branch develop local para sincronização. Ao finalizar projeto atualizar toda documentação na aplicação pela branch AjusteDocumentacao.

O projeto terá releases que representa o versionamento semântico MAJOR.MINOR.PATCH. A cada Pull Request aprovado na branch Develop deverá ser gerado o correspondente da Develop para Main e então gerar a Release para Deploy.

# Disciplina Gerenciamento de Configuração
Trabalho Avaliativo 1 
# Descrição
Desenvolver e aplicar um processo de desenvolvimento de software conforme os requisitos elencados abaixo utilizando o GitHub.
# Requisitos 
## 1
### Possuir um projeto (pode ser fictício) mas que realmente compile, que possa ser modificado e executado.
## 2
### Documentação dos problemas ou funcionalidades (ticket/backlog/issue/etc). 
O texto em si não importa muito. Pode ser gerado via https://www.lipsum.com/.
## 3 
### Documentação do próprio projeto e dos códigos fontes
Explicar no readme.md do repositório o que ele faz, como eu executo e o que devo fazer até chegar ao ponto de compilar e executar o código.
Lembrar de adicionar as ferramentas necessárias
## 4
### Rastreabilidade das alterações realizadas no repositório (vincular issues nos commits realizados).
## 5
### Fluxo de desenvolvimento com revisão de código executado através de Pull Request
Fazer ao menos 5 Pull Request.
Uma outra pull request deve ter solicitações de revisões de código
## 6
### A branch principal com o código de produção será a master ou main.
## 7
### A branch principal pode ser atualizada apenas por Pull Request. Não permitir commit direto na master/main.
## 8
### Deverá existir uma branch chamada develop onde tem os códigos que ainda não foram para a branch principal
Os desenvolvimentos das funcionalidades ou bugs devem ser feitos em branches separadas para posteriormente serem unidas (merge) com a branch develop (de desenvolvimento).
O processo de união das branches de funcionalidade e bugs na principal devem ser documentados e explicados como eles vão acontecer (merge ou PR). Fazer a documentação no próprio repositório do projeto.
## 9
### Programar as versões que serão entregues ao cliente
Quando serão entregues? (1 vez por semana, 1 vez por mês, todos os dias)
Podem ser criadas outras branches por versão se necessário. Documentar como elas serão criadas.
## 10
### Criar pelo menos 2 versões (releases)
## 11
### Mapear o cenário e realizar uma correção emergencial em uma versão (release) já criada e disponibilizada ao cliente.
A versão muda de número?
Como é o processo para fazer a correção e não perder esta correção em algum branch?
## 12
### Documentar como é o processo de desenvolvimento e vincular a imagem no readme.md do repositório. Se julgar importante explique as atividades.

