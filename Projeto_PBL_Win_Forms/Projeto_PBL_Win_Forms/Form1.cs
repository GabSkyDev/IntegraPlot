using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using ScottPlot.WinForms;
using ScottPlot;

namespace Projeto_PBL_Win_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Obtém a função inserida pelo usuário
            string funcaoUsuario = textoFuncao.Text;

            // Cria um objeto da classe Funcao para interpretar a expressão
            Funcao funcao = new Funcao(funcaoUsuario);

            // Cria um objeto da classe IntegradorTrapezio para calcular a área
            IntegradorTrapezio integrador = new IntegradorTrapezio(funcao);

            // Converte os valores de entrada do usuário para os limites de integração e número de divisões
            double a = Convert.ToDouble(textBoxA.Text); // Limite inferior
            double b = Convert.ToDouble(textBoxB.Text); // Limite superior
            int n = Convert.ToInt32(textBoxN.Text); // Número de divisões 
            int pontos = n; // Atribuição de pontos ao número de divisões

            // Calcula a área sob a curva usando o método do trapézio
            double area = integrador.CalcularArea(a, b, n);

            // Prepara os arrays para armazenar os valores de x e y (para o gráfico)
            double[] xs = new double[pontos];
            double[] ys = new double[pontos];
            double intervalo = (b - a) / (pontos - 1); // Intervalo entre os pontos

            // Calcula os valores de x e y da função em cada ponto
            for (int i = 0; i < pontos; i++)
            {
                xs[i] = a + i * intervalo;
                ys[i] = funcao.Calcular(xs[i]);
            }

            // Abre um formulário de gráfico e exibe os dados calculados
            FormGrafico graficoForm = new FormGrafico();
            graficoForm.ExibirGrafico(xs, ys, funcaoUsuario, area, a, b);
            graficoForm.Show();
        }

        // Eventos de botões para adicionar operadores e funções à expressão do usuário
        private void buttonSenx_Click(object sender, EventArgs e)
        {
            textoFuncao.Text += "Sen(";
        }

        private void buttonCosx_Click(object sender, EventArgs e)
        {
            textoFuncao.Text += "Cos(";
        }

        private void buttonTanx_Click(object sender, EventArgs e)
        {
            textoFuncao.Text += "Tan(";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textoFuncao.Text += "√(";
        }

        private void buttonEuler_Click(object sender, EventArgs e)
        {
            textoFuncao.Text += "e";
        }

        private void buttonPi_Click(object sender, EventArgs e)
        {
            textoFuncao.Text += "π";
        }
    }

    // Classe que interpreta e avalia uma função matemática
    public class Funcao
        {
            // String que contém a expressão da função
            public string expressaoString;

            public Funcao(string funcao)
            {
                // Inicializa a expressão da função
                expressaoString = funcao;

                // Substitui os nomes de funções e constantes para compatibilidade com o NCalc
                expressaoString = expressaoString.Replace("Sen(", "Sin(");
                expressaoString = expressaoString.Replace("π", "3.1416");
                expressaoString = Regex.Replace(expressaoString, @"e\^([^ ]+)", "Exp($1)");
                expressaoString = expressaoString.Replace("e", "Exp(1)");
                expressaoString = Regex.Replace(expressaoString, @"√\(([^)]+)\)", "Sqrt($1)");
                expressaoString = Regex.Replace(expressaoString, @"x\^(\d+)", "Pow(x, $1)");
                expressaoString = Regex.Replace(expressaoString, @"e\^([^ ]+)", "Exp($1)");
        }
            
            // Calcula o valor da função para um valor de x
            public double Calcular(double x)
            {
                // Cria a expressão e define o parâmetro x
                var expressao = new NCalc.Expression(expressaoString);
                expressao.Parameters["x"] = x;
                // Avalia a expressão e retorna o resultado
                return Convert.ToDouble(expressao.Evaluate());
            }
        }

    // Classe que implementa o método do trapézio para integração numérica
    public class IntegradorTrapezio
    {
        // Função a ser integrada
        public Funcao funcao; 

        // Função construtora que inicializa a função
        public IntegradorTrapezio(Funcao funcao)
        {
            this.funcao = funcao;
        }

        // Calcula a área sob a curva da função usando o método do trapézio
        public double CalcularArea(double a, double b, int n)
        {
            // Calcula o tamanho do intervalo
            double h = (b - a) / n;

            // Soma inicial considerando os extremos
            double area = (funcao.Calcular(a) + funcao.Calcular(b)) / 2.0;

            // Soma os valores no interior do intervalo
            for (int i = 1; i < n; i++)
            {
                double x_i = a + i * h;
                area += funcao.Calcular(x_i);
            }

            // Multiplica pela largura do intervalo
            area *= h;

            // Retorna a área calculada
            return area;
        }
    }
}
