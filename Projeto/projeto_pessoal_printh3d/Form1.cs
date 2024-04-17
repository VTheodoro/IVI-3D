using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_pessoal_printh3d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }



        private Calculos_Matematicos calculadora = new Calculos_Matematicos(); // Instância da classe Calculos_Matematicos para realizar os cálculos


        private bool TryParseAndSetDoubleValue(string text, out double value, TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                value = 0;
                textBox.BackColor = System.Drawing.Color.White;
                return true;
            }
            else if (double.TryParse(text, out value))
            {
                textBox.ForeColor = System.Drawing.Color.Black;
                return true;
            }
            else
            {
                MessageBox.Show($"O valor inserido para {textBox.Name} não é válido.");
                textBox.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }


        private void btn_calcularProd_Click(object sender, EventArgs e)
        {
            // Variáveis para armazenar os valores inseridos nos TextBoxes
            double valorKG, peso, kwh, consumo, tempo, depreHora, mediaFalhas, acabamento, custoFixacaoCola;

            // Verifica se os valores inseridos são válidos e atribui aos campos da calculadora
            if (TryParseAndSetDoubleValue(txt_valorKg.Text, out valorKG, txt_valorKg))
            {
                calculadora.ValorKG = valorKG;
            }

            if (TryParseAndSetDoubleValue(txt_peso.Text, out peso, txt_peso))
            {
                calculadora.Peso = peso;
            }

            if (TryParseAndSetDoubleValue(txt_precoKwh.Text, out kwh, txt_precoKwh))
            {
                calculadora.Kwh = kwh;
            }

            if (TryParseAndSetDoubleValue(txt_consumo.Text, out consumo, txt_consumo))
            {
                calculadora.Consumo = consumo;
            }

            if (TryParseAndSetDoubleValue(txt_tempo.Text, out tempo, txt_tempo))
            {
                calculadora.Tempo = tempo;
            }

            if (TryParseAndSetDoubleValue(txt_dereciacao.Text, out depreHora, txt_dereciacao))
            {
                calculadora.DepreHora = depreHora;
            }

            if (TryParseAndSetDoubleValue(txt_falhas.Text, out mediaFalhas, txt_falhas))
            {
                calculadora.MediaFalhas = mediaFalhas;
            }

            // Realiza os cálculos e exibe os resultados nos TextBoxes
            txt_resMaterial.Text = "R$" + calculadora.CalcularMaterial().ToString("F2"); // Custo do material
            txt_resEnergia.Text = "R$" + calculadora.CalcularEnergia().ToString("F2"); // Custo da energia
            txt_resFalhas.Text = "R$" + calculadora.CalcularFalhas().ToString("F2"); // Custo das falhas
            txt_resManutencao.Text = "R$" + calculadora.CalcularManutencao().ToString("F2"); // Custo da manutenção
            txt_resAcabamento.Text = "R$" + calculadora.CalcularAcabamento().ToString("F2"); // Custo do acabamento

            calculadora.Acabamento = 10; // Define o valor do acabamento como 10%
            calculadora.CustoFixacaoCola = 0.20; // Define o custo de fixação da cola

            double custoProducao = calculadora.CalcularCustoProducao(); // Calcula o custo total de produção
            lbl_resProd.Text = "R$" + custoProducao.ToString("F2"); // Exibe o custo total de produção



            //Parte final dos calculos (lucro e desconto).

            double lucroPercentual;
            if (TryParseAndSetDoubleValue(txt_lucro.Text, out lucroPercentual, txt_lucro))
            {
                double valorVenda = calculadora.CalcularValorVenda(lucroPercentual);
                txt_resVenda.Text = "R$" + valorVenda.ToString("F2"); // Exibe o valor de venda com duas casas decimais

                double lucroValor = valorVenda - calculadora.CalcularCustoProducao();
                txt_resLucro.Text = "R$" + lucroValor.ToString("F2"); // Exibe o valor do lucro com duas casas decimais
            }


        }



        private void txt_comprimento_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_lucro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
