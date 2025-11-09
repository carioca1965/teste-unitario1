# ✅ Testes Unitários em C# – Desafio DIO (Trilha .NET)

Este repositório contém a solução completa do **Desafio de Testes Unitários** da **Digital Innovation One (DIO)**, parte da trilha **.NET**.

O objetivo deste desafio é implementar testes unitários utilizando **xUnit**, garantindo a qualidade, confiabilidade e manutenção do código.

---

# 🎯 Objetivo do Projeto

Você trabalha em um sistema que frequentemente apresenta bugs e comportamentos inesperados. Para melhorar a qualidade e confiabilidade do software, você implementou **testes unitários** nas classes principais responsáveis por regras de validação.

O desafio consiste em:

* Criar testes para métodos relacionados a **listas**
* Criar testes para métodos de **strings**
* Validar cenários **positivos e negativos**
* Garantir a cobertura mínima das funcionalidades críticas

---

# 🧪 Tecnologias Utilizadas

* ✅ **.NET 6+**
* ✅ **xUnit** (framework de testes)
* ✅ **C#**

---

# 🗂️ Estrutura do Projeto

```
📦 teste-unitario1
 ┣ 📁 Console
 ┃ ┣ 📄 ValidacoesLista.cs
 ┃ ┗ 📄 ValidacoesString.cs
 ┣ 📁 Tests
 ┃ ┣ 📄 ValidacoesListaTests.cs
 ┃ ┗ 📄 ValidacoesStringTests.cs
 ┣ 📄 README.md
 ┗ 📄 teste-unitario1.sln (opcional)
```

---

# ✅ Funcionalidades Testadas

## 🔹 ValidacoesLista

| Método                           | Objetivo                                        |
| -------------------------------- | ----------------------------------------------- |
| **RemoverNumerosNegativos**      | Retorna lista apenas com números positivos/zero |
| **ListaContemDeterminadoNumero** | Verifica se um número existe na lista           |
| **MultiplicarNumerosLista**      | Multiplica todos os elementos por um número     |
| **RetornarMaiorNumero**          | Retorna o maior valor da lista                  |
| **RetornarMenorNumero**          | Retorna o menor valor da lista                  |

---

## 🔹 ValidacoesString

| Método                   | Objetivo                                  |
| ------------------------ | ----------------------------------------- |
| **QuantidadeCaracteres** | Retorna o total de caracteres             |
| **ContemCaractere**      | Verifica se o texto contém um trecho      |
| **TextoTerminaCom**      | Verifica se o texto termina com um trecho |

---

# ✅ Exemplos de Testes Implementados

### ✅ Deve remover números negativos

### ✅ Deve conter o número 9 na lista

### ✅ Não deve conter o número 10

### ✅ Deve multiplicar os elementos da lista

### ✅ Deve retornar o maior e o menor número

### ✅ Deve retornar a quantidade correta de caracteres

### ✅ Deve confirmar presença/ausência de palavras

### ✅ Deve validar se o texto termina corretamente

---

# ▶️ Como Executar os Testes

Na raiz do projeto, execute:

```bash
dotnet test
```

Você deverá ver todos os testes **passando (✔ Verde)**.

---

# 🚀 Como Subir no GitHub

```bash
git add .
git commit -m "feat: testes unitários completos"
git branch -M main
git push -u origin main
```

---

# ✅ Conclusão

Com este projeto, você garante uma base sólida de testes unitários, reduzindo bugs e aumentando a confiabilidade do sistema.
