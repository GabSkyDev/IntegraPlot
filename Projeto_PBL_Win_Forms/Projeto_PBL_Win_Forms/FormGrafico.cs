using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projeto_PBL_Win_Forms
{
    public partial class FormGrafico : Form
    {
        public FormsPlot formsPlot; // Componente ScottPlot para exibir gráficos

        public FormGrafico()
        {
            InitializeComponent();

            // Inicializa o objeto FormsPlot com dimensões e ancoragem
            formsPlot = new FormsPlot() {
                Width = 480, // Largura do gráfico
                Height = 330, // Altura do gráfico
                Anchor = AnchorStyles.Top | AnchorStyles.Left // Ancoragem do gráfico no canto superior esquerdo
            };

            // Adiciona o FormsPlot ao formulário
            this.Controls.Add(formsPlot);
        }

        // Método para exibir o gráfico com os dados fornecidos
        public void ExibirGrafico(double[] xs, double[] ys, string funcao, double area, double a, double b)
        {
            // Limpa qualquer gráfico existente
            formsPlot.Plot.Clear();

            // Adiciona um gráfico da função com preenchimento abaixo da curva
            var sp = formsPlot.Plot.Add.Scatter(xs, ys);
            sp.FillY = true; // Preenche a área abaixo da curva
            sp.FillYColor = sp.Color.WithAlpha(.2); // Define a transparência do preenchimento

            // Atualiza o gráfico exibido
            formsPlot.Refresh();

            // Formata a expressão da função para exibição mais amigável
            string funcaoTexto = funcao.Replace("*", "");
            funcaoTexto = funcaoTexto.Replace("Sqrt(x)", "√");

            // Atualiza os valores exibidos no formulário
            valorFuncao.Text = funcaoTexto;
            valorInicial.Text = $"{a}";
            valorFinal.Text = $"{b}";
            valorArea.Text = $"{area}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void valorArea_Click(object sender, EventArgs e)
        {

        }

        private void valorFuncao_Click(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
