# Avaliação

## Introdução

Este projeto reflete um dos desafios realizados como parte de um processo seletivo para uma empresa na Cidade de Blumenau-SC.

Buscou-se atender os requisitos solicitados, além de ter sido adicionado conhecimentos como concernentes a gestão de projetos, gerência de configuração, entre outros.


## Cenário

Você trabalha em uma empresa de Terceirização de Mão de Obra de grande importância para sua cidade. O chefe do departamento de pessoal decidiu que chegou a hora de implementar uma nova funcionalidade que permita calcular e demonstrar o Imposto de Renda do Contribuinte de forma separada e independente da Folha de Pagamento.

Sua função é elaborar um algoritmo que o usuário deve digitar o CPF, nome do contribuinte, número de dependentes e renda bruta mensal de cada contribuinte.

Após encerrar a entrada dos contribuintes, deve solicitar o valor do Salário Mínimo e então calcular e escrever o IR de cada contribuinte, em ordem crescente de valor de IR e ordem crescente de nome.

**Regras para cálculo do IR do contribuinte**:

Para cada contribuinte será concedido um desconto de 5% do valor Salário Mínimo por dependente. Os valores da alíquota para cálculo do imposto são:

|Renda Líquida                     | Alíquota |
|----------------------------------|---------:|
|até 2 salários mínimos            | isento   |
|acima de 2 até 4 salários mínimos | 7,5%     |
|acima de 4 até 5 salários mínimos | 15,0%    |
|acima de 5 até 7 salários mínimos | 22,5%    |
|acima de 7 salários mínimos       | 27,5%    |


**Lembrete:** **`Renda Líquida = Renda Bruta - Descontos por Dependente`**

## Requisitos

* O Backend deve ser escrito em .NET;
* O Frontend e a sua Usabilidade (UX do Frontend) não serão critérios avaliados, mas caso seja escrito em HTML/JS - o framework JS ficará a critério do desenvolvedor;
* Os contribuintes não precisam ser persistidos em um banco de dados, porém conhecimento em algum Framework de ORM será bem-vindo;
* Testes unitários, divisão das camadas, modelagem, design patterns são fatores que serão levados em conta;

## Recursos utilizados no desenvolvimento da aplicação:

**Ferramentas**

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|Visual Studio 2017                        |[Guia][GuiaVS2017]                |[IDE][IDEVS2017]  |
|SQL Server 2017                           |[Guia][GuiaSQL2017]               |[IDE][IDESQL2017] |


**Tecnologias**

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|ASP.NET Core 2.0                          |[Guia][GuiaASPNetCore]            |N/A               |
|Entity Framework Core 2.0                 |[Guia][GuiaEntityCore]            |N/A               |
|Migration                                 |[Guia][GuiaMigrations]            |N/A               |
|AutoMapper                                |N/A                               |N/A               |
|Flunt                                     |N/A                               |N/A               |
|FluentAssertions                          |N/A                               |N/A               |
|NSubstitute                               |N/A                               |N/A               |


**Arquiteturas e Conceitos**

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|Conceitos de DDD (Domain Driven Design)   |[Tutorial][GuiaDDD]               |N/A               |
|Conceitos de TDD (Test Driven Design)     |N/A                               |N/A               |
|Repositório de Dados (Repository Pattern) |[Tutorial][GuiaRepositoryPattern] |N/A               |
|SOLID                                     |N/A                               |N/A               |
|Clean Code                                |N/A                               |N/A               |

## Sobre o projeto

O projeto Imposto de Renda, tem o intuito de demonstrar uma aplicação em .Net Core para realizar cálculo de imposto de renda.


## Mendigo de estrelas :star:

Se você gostou deste projeto ou te ajudou de alguma forma com algum conceito, clica na estrelinha, isso ajuda muito.


## Tem alguma pergunta ou sugestão de melhoria neste projeto?

Sinta-se à vontade em abrir um [issue][DefeitoIR] ou [pull request][PullRequest].

[//]: # (Links de referências para o quadro de recursos utilizados)

[GuiaVS2017]: <https://docs.microsoft.com/pt-br/visualstudio/ide/>
[IDEVS2017]: <https://www.visualstudio.com/pt-br/downloads/>
[GuiaCSharp]: <https://docs.microsoft.com/pt-br/dotnet/csharp/>
[GuiaDDD]: <http://www.agileandart.com/2010/07/16/ddd-introducao-a-domain-driven-design/>
[GuiaASPNetCore]: <https://docs.microsoft.com/pt-br/dotnet/core/>
[GuiaEntityCore]: <https://docs.microsoft.com/pt-br/dotnet/framework/>
[GuiaRepositoryPattern]: <https://code.msdn.microsoft.com/windowsdesktop/Implementando-Repositrio-aabcdbce>
[GuiaMigrations]: <https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/>
[GuiaSQL2017]: <https://docs.microsoft.com/pt-br/sql/sql-server/sql-server-technical-documentation>
[IDESQL2017]: <https://www.microsoft.com/pt-br/sql-server/sql-server-downloads>


[//]: # (Links de referências aos problemas neste projeto)

[DefeitoIR]: <https://github.com/alexandredorea/IR/issues>
[PullRequest]: <https://github.com/alexandredorea/IR/pulls>
