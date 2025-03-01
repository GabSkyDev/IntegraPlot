# IntegraPlot

O **IntegraPlot** é uma aplicação gráfica desenvolvida em C# com .NET e Windows Forms, utilizando as bibliotecas ScottPlot e NCalc, que permite calcular integrais definidas de funções algébricas e exibir seus gráficos. O projeto foi desenvolvido como parte de um PBL (Problem-Based Learning) que integrou as disciplinas de Algoritmos e Cálculo I.

## Linguagens e Frameworks

![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)

## Bibliotecas

![ScottPlot](https://img.shields.io/badge/ScottPlot-FF6F00?style=for-the-badge&logo=plotly&logoColor=white)
![NCalc](https://img.shields.io/badge/NCalc-2.0.0-blue?logo=.net&logoColor=white)

### Controle de Versão

![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)

## Funcionalidades

- **Inserção de funções**: Aceita funções polinomiais, logarítmicas e trigonométricas.
- **Cálculo de integral definida**: Calcula a área sob a curva da função entre os limites especificados.
- **Visualização gráfica**: Exibe o gráfico da função com destaque para a área calculada.
- **Informações detalhadas**: Mostra a função inserida, os limites de integração, o valor da integral e a área sob a curva.

## Como usar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/IntegraPlot.git
   Abra o projeto no Visual Studio.
   Compile e execute o projeto.
   Insira a função desejada e os limites de integração.
   Clique em "Calcular" para ver o gráfico e os resultados.

## ⚠️ Aviso Importante

Ao inserir funções no programa, **siga estritamente o formato abaixo**:

- Use `*` para multiplicação. Exemplo: `3*x` (não use `3x`).
- Use `^` para exponenciação. Exemplo: `x^2` (não use `x²`).
- Use parênteses para agrupamento. Exemplo: `(x + 2) * 3`.
- Para funções trigonométricas, como `sin(x)`, `cos(x)`, `tan(x)`. Utilize os botões exibidos na tela.
