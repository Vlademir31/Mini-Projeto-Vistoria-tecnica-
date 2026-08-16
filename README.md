# AutoCheck.Console - Sistema de Gestão e Laudos Automotivos

## Índice

+ [Sobre o Projeto](#sobre-o-projeto)
+ [Objetivos](#objetivos)
+ [Contexto do Projeto](#contexto-do-ptojeto)
+ [Funcionalidades](#funcionalidades)
+ [Tecnologias Utilizadas](#tecnologias-utilizadas)
+ [Estrutura Atual do Projeto](#estrutura-atual-do-projeto)
+ [Como Executar o Projeto](#como-executar-o-projeto)
+ [Próximas Etapas](#próximas-etapas)
+ [Melhorias Futuras](#melhorias-futuras)
+ [Controle de Versão](#controle-de-versão)
+ [Licença](#licença)
+ [Autor](#autor)

---

## Sobre o Projeto

O ***AutoCheck.ConsoleApp*** é uma aplicação desenvolvida em C# /.NET com o objetivo de simular um sitema de gestão de vistorias e laudos automotivos.

A proposta do sistema é permitir que informações de um veiculo sejam avaliadas durante um processo de vistoria, possibilitando posteriormente o registro dos resultados, identificação de ped^ncias, cálculo de pontuação e geração de relatórios.

O projeto está sendo desenvolvido como parte do Mini-Projeto Avaliativo-Módulo 1, cujo desafio consiste na construção de uma aplicação Console capaz de processar uma vistoria veicular.

O projeto tem como foco principal a aplicação prática dos consceitos de C# e Programação Orientada a Objetos estudados durante a formação.

---

## Objetivos

O AutoCheck tem como objetivos:

- Desenvolver uma aplicação Console utilizando C#.
- Aplicar conceitos de Programação Orientada a Objetos.
- Organizar o sitema utilizando classes com responsabilidades especificas.
- Trabalhar com menus e navegação no terminal.
- Representar diferentes tipos de veiculos.
- Criar checklists de inspeção.
- Avaliar itens de uma vistoria.
- Registrar situações encontrads durante a inspeção.
- Calcular a pontuação da vistoria.
- Classificar a situação do veiculo.
- Gerar relatórios e laudos.

---

## Contexto do Projeto

A vistoria veicular é um processo utilizado para avaliar as consições de um veiculo antes de determinadas operções, como compra, venda, troca ou análise por empresas do setor automotivo.
O projeto proposto pelo curso utiliza esse contexto para aplicar conceitos de desenvolvimento BAck-End com .NET.
A aplicação deverá trabalhar futuramente com diferentes tipos de veiculos. como:

- Carro
- Moto
- Caminhão

Cada tipo de veiculo deverá possuir caracteristicas próprias e um checklist especifico de inspenção.
Durante a vistoria os itens poderão ser classificados como:

- Bom
- Regular
- Ruim

Essas Classificações serão utilizadas posteriormente para calcular a pontuação e o percentual de aprovação do veiculo.

## Funcionalidades Atuais

Neste estágio inicial o sistema posui a estrutura básica de inicialização e navegação.

### Tela de Apresentação

Ao iniciar a aplicação o sistema apresenta uma tela de boas vindas:

```
=====================================
     
Sistema de Gestão e Laudos Automotivos

   A certeza de um automovel seguro.

=====================================

Inicializando o sistema ...

```

Após a apresentação o sistema direciona o usuário para o menu principal.


# Menu Principal

Atualmente o sistema apresenta o seguinte menu:

```
====================

  GESTÃO VEICULAR

====================

1 - Vistoria

2 - Relatório

3 - Laudo Cautelar

0 - Sair

Escolha uma opção:
```

As opções já estão estruturadas para receber as futuras funcionalidades do sistema.

**1. Vistoria**

Opção destinada ao processo de vistoria veicular.

Atualamente a opção está preparada na navegação, mas a implementação completa da vistoria ainda está em desenvovimento.

**2. Relatório**

Opção destinada à futura consulta dos resultados das vistorias realizadas.

**3. Laudo Cautelar**

Opção destinada à futura implementação do processo de geração e apresentação do laudo cautelar.

**0. Sair**

Encerra a execução do sistema.

# Tecnologias Utilizadas

Até o momento o projeto utiliza:

## Desenvolvimento

+ C#
+ .NET
+ Console Aplication

# Controle de Versão

- Git
- GitHub

## Conceitos de C# já utilizados:

+ Classes
+ Métodos
+ Objetos
+ While
+ For
+ Switch
+ Console.ReadLine()
+ Console.WriteLine()
+ Variáveis
+ Tipos string e boll
+ Controle de Fluxo
+ Namespace
+ Instanciação de objetos

# Estrutura Atual do projeto

A estrutura inicial do projeto está sendo organizada da seguinte forma:

```text
AutoCheck.ConsoleApp/
│ 
├── README.md
│ 
├── Program.cs
│
└── Menus/
│    ├── MenuApresentacao.cs
│    └── MenuPrincipal.cs
│
├── Models/
│      └── ItemVistoria.cs
│
├── Services/
│     └── MotorVistoria.cs
│ 
└── .gitignore


``` 
---
## Program.cs

Responsável por iniciar a aplicação.

O **Program** instancia o **MenuApresentacao** e chama seu método **Exibri()**.

                         Program
                            ↓
                    MenuApresentacao    
---

## MenuApresentacao

Responsável pela apresentação inicial do sistema.
Após apresentar a mensagem de boas-vindas, a classe encaminha a execução para o **MenuPrincipal**.

                     MenuApresentacao
                            ↓
                      MenuPrincipal
---
## MenuPrincipal

Responsável pela navegação principal do sitema.

O menu utiliza uma estrutura de repetição **While** e uma estrutura **switch** para processar a opção escolhida pelo usuário.

---

# Estrutura Atual do Projeto

O fluxo implementado atualmene é:

                 Program.cs
                    │
                    ▼
            MenuApresentacao.cs
                    │
                    ▼
              MenuPrincipal
                    │
                    ├── 1 - Vistoria
                    │     
                    ├── 2 - Relatório
                    │
                    ├── 3 - Laudo Cautelar
                    │
                    └── 0 - Sair

Neste momento as opções de **Vistoria, Relatório e Laudo Cautelar** estão estruturadas no menu enquanto suas funcionalidades serão implementadas nas próximas etapas.

---

# Como Executar o Projeto

## Pré-requisitos

Para executar o projeto é necessário ter instalado **.NET SDK** e recomendados possuir o Git instalado para clonar o repositório..

## Executando a apllicação

Iniciando o projeto:

1. Clonar o repositório

   git clone https://github.com/Vlademir31/Mini-Projeto-Vistoria-tecnica-.git

2. Acessar a pasta do projeto

   cd Mini-Projeto-Vistoria-tecnica
   cd src
   cd AutoCheck.ConsoleApp

3. Restaurar as dependências

   dotnet restore

4. Compilar o projeto

   dotnet build

5. Executar a aplicação

   dotnet run

Ao executar o comando **dotnet run** o sistema deverá iniciar a aplicação e apresentar a tela de apresentação do **AutoCheck** e posteriormente exibir o **MenuPrincipal**.   

## Fluxo dos comandos

            git clone
                ↓
    Mini-Projeto-Vsitoria-tecnica
                ↓
             cd src
                ↓
        cd AutoCheck.ConsoleApp
                ↓
          dotnet restore
                ↓
          dotnet build
                ↓
            dotnet run    

## Comandos principais

|Comando        | Função |
| :-------     | :------ |
|`git clone`      | Baixa o projeto do GitHub
|`cd`             | Entra na pasta do projeto
|`dotnet restore` | Restaura as dependências
|`dotnet build`   | Compila o projeto
|`dotnet run`     | Compila e executa a aplicação

---

# Próximas Etapas

O desenvolvimento será realizado de forma incremental.

As próximas etapas planejadas são:

1. Criar o modelo ItemVistoria
2. Criar a classe base Veiculo
3. Criar as classes **Carro, Moto, Caminhão**
4. Implementar herança
5. Implementar polimorfismo com **virtual** e **override**
6. Criar os checklists especificos
7. criar o fluxo de realização
8. Implementar o registro do status do itens
9. Criar o **MotorVistoria**
10. Implementar o cálculo da pontuação
11. Implementar o cálculo do percentual
12. Implementar a  classificação do veiculo
13. Implementar o relatório de pendências
14. Implementar as recomendações de serviços
15. Implementar o relatório das vistorias
16. Evoluir a funcionalidade de Laudo Cautelar

A organização segue a estrutura recomendada no enunciado do mini-projeto, que prevê os modelos **ItemVistoria, Veiculo, Carro, Moto e Caminhão** além do serviço **MotorVistoria**.

# Melhorias futuras

Após a conclusão dos requisitos principais do mini-projeto, o AutoCheck poderá evoluir com novas funcionalidades como:

+ Cadastro de clientes
+ Cadastro de veículos
+ Histórico de vistorias
+ Geração de laudos em PDF
+ Armazenagem em banco de dados
+ Sistema de usuários
+ Controle de acesso
+ Dashboard de indicadores
+ Exportação de relatórios
+ Histórico de manutenção
+ Integração com serviços externos
+ API para integração

---


# Licença

Este projeto foi desenvolvido para fins acadêmicos e educacionais.

---

# Autor

Vlademir Trindade de Oliveira

Projeto desenvolvido como parte do **Mini-Projeto Avaliativo - Módulo 01** com foco no desenvolvimento Back-End aplicando:

 + C#
 + .NET
 + POO


