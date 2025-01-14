# Exercícios para Etapa de Testes - Vaga Target Sistemas

Este repositório contém os exercícios propostos para a etapa de testes da vaga de desenvolvimento na **Target Sistemas**. Os exercícios envolvem a implementação de soluções usando C#.

## Exercícios

### Exercício 1
**Descrição**: 
Escreva um programa que calcule o somatório de um número definido, onde o número de iterações é dado pela variável `INDICE`. 

**Objetivo**: 
- Calcular o somatório de um valor `SOMA` com base no número de iterações (`INDICE`).
- Exibir o valor de `SOMA` ao final do processamento.

**Saída Esperada**:
- Imprimir o valor de `SOMA` após a execução do loop.

### Exercício 2
**Descrição**: 
Dado um número, escreva um programa que calcule a sequência de Fibonacci até um número informado e verifique se o número informado pertence à sequência.

**Objetivo**:
- Calcular a sequência de Fibonacci até o número informado.
- Exibir a sequência de Fibonacci.
- Verificar se o número informado pertence à sequência e retornar uma mensagem.

**Exemplo**:
- Se o número informado for 21, o programa deve verificar se 21 está na sequência de Fibonacci.

### Exercício 3
**Descrição**: 
Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, o programa deve calcular e retornar:
- O menor valor de faturamento ocorrido em um dia do mês.
- O maior valor de faturamento ocorrido em um dia do mês.
- O número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

**Objetivo**:
- Filtrar os dias com faturamento (ignorando dias sem faturamento).
- Calcular o menor e maior valor de faturamento.
- Calcular a média mensal e o número de dias com faturamento superior à média.

**Fonte de Dados**:
- Os dados de faturamento mensal são lidos de um arquivo **`faturamento.json`**.

### Exercício 4
**Descrição**: 
Calcule o percentual de representação que cada estado teve dentro do valor total mensal de uma distribuidora, com os seguintes valores de faturamento:

- SP – R$67.836,43
- RJ – R$36.678,66
- MG – R$29.229,88
- ES – R$27.165,48
- Outros – R$19.849,53

**Objetivo**:
- Calcular o percentual de cada estado em relação ao faturamento total mensal da distribuidora.

**Fórmula de Cálculo**:
\[ \text{Percentual} = \left( \frac{\text{Faturamento do Estado}}{\text{Faturamento Total}} \right) \times 100 \]

### Exercício 5
**Descrição**: 
Inverta os caracteres de uma string.

**Objetivo**:
- Criar um programa que inverta os caracteres de uma string informada. Não utilize funções prontas como `reverse`.

**Exemplo**:
- Entrada: "Exemplo de String para inverter"
- Saída: "retrevni arpS gnirt ed olpmE"


## Estrutura do Repositório

- **Program.cs**: Contém a lógica dos exercícios.
- **faturamento.json**: Arquivo JSON contendo os dados de faturamento diário.


## Tecnologias Usadas

- **C#**
- **Newtonsoft.Json** (para manipulação de JSON)
- **.NET Core**
