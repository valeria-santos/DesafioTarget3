# CalculoJuros

Aplicação desenvolvida em **C#** para calcular juros de uma conta de acordo com a quantidade de dias de atraso em relação à data de vencimento.

O projeto utiliza **Programação Orientada a Objetos (POO)** e **testes unitários com xUnit**, mantendo a regra de negócio separada da interação com o usuário.

## 📋 Descrição

A aplicação recebe o **valor de uma conta** e a **data de vencimento**, calcula os juros considerando uma multa de **2,5% ao dia de atraso** e apresenta o valor atualizado.

O programa permite informar vários valores consecutivamente e continua executando até que o usuário escolha não informar outro valor.

Entre as funcionalidades estão:

* Entrada do valor da conta;
* Entrada da data de vencimento;
* Cálculo da quantidade de dias de atraso;
* Cálculo de juros de 2,5% ao dia;
* Cálculo do valor atualizado da conta;
* Identificação de contas sem atraso;
* Repetição do menu para novos cálculos;
* Validação das regras de negócio por meio de testes unitários.

## 🛠️ Tecnologias utilizadas

* C#
* .NET
* Programação Orientada a Objetos (POO)
* xUnit
* Testes unitários

## 🚀 Como executar o projeto

### 1. Clone o repositório

Clone o projeto utilizando:

```bash
git clone URL_DO_REPOSITORIO
```

Depois, entre na pasta do projeto:

```bash
cd DesafioTarget3
```

### 2. Execute a aplicação

Entre na pasta `CalculoJuros`:

```bash
cd CalculoJuros
```

Execute o projeto com:

```bash
dotnet run
```

A aplicação será compilada e executada diretamente pelo terminal.

## 🧪 Como executar os testes

Para executar os testes unitários, volte para a pasta principal:

```bash
cd ..
```

Entre na pasta `CalculoJuros.Tests`:

```bash
cd CalculoJuros.Tests
```

Execute:

```bash
dotnet test
```

O comando irá compilar o projeto de testes e executar todos os testes automatizados utilizando **xUnit**.

## ✅ Testes unitários

Os testes automatizados têm como objetivo validar as principais regras do cálculo de juros, incluindo:

* Conta com vencimento na data atual;
* Conta com vencimento futuro;
* Conta com 1 dia de atraso;
* Conta com 3 dias de atraso;
* Conta com 10 dias de atraso;
* Cálculo de juros sobre valores decimais;
* Cálculo do valor atualizado;
* Validação do valor original quando não há atraso;
* Validação da aplicação de 2,5% de juros por dia.

## 💰 Cálculo de juros

A aplicação utiliza uma multa de **2,5% ao dia de atraso**.

O cálculo é realizado considerando:

```text
Juros por dia = Valor da conta × 2,5%
```

E:

```text
Juros total = Juros por dia × Dias de atraso
```

O valor atualizado é calculado da seguinte forma:

```text
Valor atualizado = Valor original + Juros total
```

### Sem atraso

Se a data de vencimento for hoje ou estiver no futuro:

```text
Valor da conta: R$ 1.000,00
Juros: R$ 0,00
Valor atualizado: R$ 1.000,00
```

### Com atraso

Exemplo com 3 dias de atraso:

```text
Valor da conta: R$ 1.000,00
Juros por dia: R$ 25,00
Dias de atraso: 3

Juros total: R$ 75,00
Valor atualizado: R$ 1.075,00
```

## 🔄 Repetição do menu

A aplicação permite realizar vários cálculos sem precisar reiniciar o programa.

Após cada cálculo, o usuário pode escolher:

```text
Deseja informar outro valor? (S/N):
```

Ao informar `S`, um novo cálculo será iniciado.

Ao informar `N`, o programa será encerrado.

## 🎯 Objetivo

O objetivo do projeto é desenvolver uma solução em **C#** capaz de calcular juros de contas em atraso de forma organizada e confiável, aplicando conceitos de **Programação Orientada a Objetos**, separação de responsabilidades e **testes unitários automatizados**.

A aplicação busca garantir que os juros sejam calculados corretamente de acordo com a quantidade de dias de atraso e que o valor atualizado da conta seja apresentado corretamente.

## 👩‍💻 Execução rápida

### Aplicação

```bash
cd CalculoJuros
dotnet run
```

### Testes

```bash
cd CalculoJuros.Tests
dotnet test
```

