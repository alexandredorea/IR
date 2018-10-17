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

## Existe alguma pergunta ou sugestão de melhoria neste projeto?

Sinta-se à vontade em abrir um [issue][DefeitoIR] ou [Pull Request][PullRequest].

[//]: # (Links de referências aos problemas neste projeto)

[DefeitoIR]: <https://github.com/alexandredorea/IR/issues>
[PullRequest]: <https://github.com/alexandredorea/IR/pulls>
