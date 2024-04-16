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

        private bool TryParseAndSetDoubleValue(string text, out double value, ref TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                value = 0;
                textBox.BackColor = System.Drawing.Color.White;
                return true;
            }
            else if (double.TryParse(text, out value))
            {
                textBox.ForeColor = System.Drawing.Color.White;
                return true;
            }
            else
            {
                MessageBox.Show($"O valor inserido para {textBox.Name} não é válido.");
                textBox.ForeColor = System.Drawing.Color.Red;
                return false;
            }
        }


        Calculos_Matematicos cM = new Calculos_Matematicos();
        private void btn_calcularProd_Click(object sender, EventArgs e)
        {

            double valorKG, peso, kwh, consumo, tempo, depreHora, mediaFalhas;

            if (TryParseAndSetDoubleValue(txt_valorKg.Text, out valorKG, ref txt_valorKg)){
                cM.valorKG = valorKG;
            }

            if (TryParseAndSetDoubleValue(txt_peso.Text, out peso, ref txt_peso)){
                cM.peso = peso;
            }

            if (TryParseAndSetDoubleValue(txt_precoKwh.Text, out kwh, ref txt_precoKwh)){
                cM.kwh = kwh;
            }

            if (TryParseAndSetDoubleValue(txt_consumo.Text, out consumo, ref txt_consumo)){
                cM.consumo = consumo;
            }

            if (TryParseAndSetDoubleValue(txt_tempo.Text, out tempo, ref txt_tempo)){
                cM.tempo = tempo;
            }

            if (TryParseAndSetDoubleValue(txt_dereciacao.Text, out depreHora, ref txt_dereciacao)){
                cM.depreHora = depreHora;
            }

            if (TryParseAndSetDoubleValue(txt_falhas.Text, out mediaFalhas, ref txt_falhas)){
                cM.mediaFalhas = mediaFalhas;
            }

            txt_resMaterial.Text = "R$" + cM.cMaterial();
            txt_resEnergia.Text = "R$" + cM.cEnergia();
            txt_resFalhas.Text = "R$" + cM.cFalhas();
            txt_resManutencao.Text = "R$" + cM.cManutencao();

            lbl_resProd = cM.cSomaProd();
        }
    }
}
