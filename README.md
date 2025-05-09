
# Desafio Técnico em C#

Este projeto contém soluções para cinco questões técnicas em C#. Cada questão pode ser executada a partir do menu interativo.

## Como rodar

1. Tenha o [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado
2. Clone este repositório
3. Navegue até a pasta do projeto
4. Execute:

```bash
dotnet run
```

## Questões

Questões
1. Soma com laço while
   Este código realiza a soma de números inteiros de 1 até 13 utilizando um laço while. Ele simula um algoritmo simples que incrementa um contador K e acumula seu valor na variável SOMA, imprimindo o resultado final.


2. Verificação de número na sequência de Fibonacci
   Este programa verifica se um número informado pelo usuário pertence ou não à sequência de Fibonacci. A sequência inicia com 0 e 1, e cada novo número é a soma dos dois anteriores. O algoritmo percorre a sequência até atingir ou ultrapassar o número informado.


3. Análise de faturamento diário a partir de JSON
   O programa lê um arquivo dados.json contendo o faturamento diário de uma distribuidora. Ele calcula:

    ```
   O menor valor de faturamento diário (ignorando dias sem faturamento).

    O maior valor de faturamento diário.

    Quantos dias tiveram faturamento acima da média mensal (considerando apenas dias com valor maior que zero).


4. Cálculo de percentuais de faturamento por estado
   Dado o valor total de faturamento mensal por estado (SP, RJ, MG, ES e Outros), o programa calcula e imprime o percentual que cada estado representa no total geral.

5. Inversão de string sem funções prontas
   O programa solicita que o usuário informe uma string e, sem utilizar funções prontas como Reverse, inverte os caracteres manualmente, exibindo o resultado.