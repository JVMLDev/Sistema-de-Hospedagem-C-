# 🏨 Sistema de Hospedagem --- Desafio de Projeto (DIO .NET)

Este repositório contém a solução do **Desafio de Projeto do módulo
"Explorando a Linguagem C#"** da Trilha .NET da
[DIO](https://www.dio.me/).\
O objetivo é implementar um sistema simples de hospedagem, aplicando
orientação a objetos e boas práticas da linguagem C#.

------------------------------------------------------------------------

## 📌 Objetivo do Desafio

Construir um sistema capaz de gerenciar **hóspedes**, **suítes** e
**reservas** em um hotel.\
Você deverá implementar a lógica que conecta essas entidades e calcular
corretamente:

-   Quantidade de hóspedes
-   Valor total da diária
-   Regras de desconto
-   Validações de capacidade

------------------------------------------------------------------------

## 🧱 Estrutura do Sistema

O sistema é composto por três classes principais:

### **1. Pessoa**

Representa um hóspede.

### **2. Suíte**

Representa uma suíte do hotel, contendo: - Descrição - Capacidade
máxima - Valor da diária

### **3. Reserva**

Relaciona hóspedes e suíte, contendo: - Lista de hóspedes - Suíte
selecionada - Quantidade de dias reservados

------------------------------------------------------------------------

## 📏 Regras e Validações do Sistema

### ✔️ **Validação de capacidade**

Não é permitido reservar uma suíte com capacidade menor que a quantidade
de hóspedes.\
Exemplo: - Suíte com capacidade para **2** - Tentativa de reservar para
**3 hóspedes**

➡️ Deve lançar uma **Exception**

------------------------------------------------------------------------

### ✔️ **ObterQuantidadeHospedes()**

Deve retornar o **total de hóspedes** adicionados à reserva.

------------------------------------------------------------------------

### ✔️ **CalcularValorDiaria()**

Deve retornar:

    Valor final = Dias reservados × Valor da diária

Com regra de desconto:

-   Reservas **≥ 10 dias** recebem **10% de desconto** no valor total

Exemplo:

    10 dias × R$100 = R$1000
    Desconto 10% → R$900

------------------------------------------------------------------------

## 🧩 O que você deve implementar

O código inicial fornecido no desafio contém marcações `TODO`, indicando
onde a lógica deve ser completada.\
Sua tarefa é implementar as regras de negócio descritas acima,
garantindo o funcionamento correto de:

-   Cadastro de hóspedes
-   Validação da capacidade da suíte
-   Cálculo do valor da diária
-   Aplicação do desconto quando necessário

------------------------------------------------------------------------

## 🚀 Como executar

1.  Clone este repositório:

    ``` bash
    git clone https://github.com/JVMLDev/Sistema-de-Hospedagem-C-.git
    ```

2.  Abra o projeto no Visual Studio ou VS Code

3.  Execute o programa:

    ``` bash
    dotnet run
    ```

------------------------------------------------------------------------

## 🎯 Objetivo Educacional

Este projeto reforça conceitos fundamentais como:

-   Classes e Objetos
-   Encapsulamento
-   Coleções
-   Regras de negócio
-   Exceptions
-   Cálculo e validação de dados

Faz parte da trilha de aprendizado em .NET e prepara o aluno para
projetos mais avançados.
