using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pessoal_printh3d
{
    public class Calculos_Matematicos
    {
        // Campos para armazenar os valores necessários para os cálculos
        private double valorKG; // Valor por quilograma
        private double peso; // Peso da peça em quilogramas
        private double kwh; // Custo por quilowatt-hora
        private double consumo; // Consumo de energia em quilowatts
        private double tempo; // Tempo de produção em minutos
        private double depreHora; // Depreciação por hora
        private double mediaFalhas; // Média de falhas por peça
        private double acabamento; // Valor percentual do acabamento
        private double custoFixacaoCola = 0.20; // Custo fixo da cola em reais

        // Propriedades para acesso aos campos privados
        public double ValorKG
        {
            get { return valorKG; }
            set { valorKG = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Kwh
        {
            get { return kwh; }
            set { kwh = value; }
        }

        public double Consumo
        {
            get { return consumo; }
            set { consumo = value; }
        }

        public double Tempo
        {
            get { return tempo; }
            set { tempo = value; }
        }

        public double DepreHora
        {
            get { return depreHora; }
            set { depreHora = value; }
        }

        public double MediaFalhas
        {
            get { return mediaFalhas; }
            set { mediaFalhas = value; }
        }

        public double Acabamento
        {
            get { return acabamento; }
            set { acabamento = value; }
        }

        public double CustoFixacaoCola
        {
            get { return custoFixacaoCola; }
            set { custoFixacaoCola = value; }
        }

        // Métodos para calcular cada componente do custo de produção
        public double CalcularMaterial()
        {
            return (ValorKG / 1000) * Peso; // Calcula o custo do material
        }

        public double CalcularEnergia()
        {
            return ((Kwh / 1000) * Consumo) * (Tempo / 60); // Calcula o custo da energia
        }

        public double CalcularManutencao()
        {
            return Tempo * DepreHora; // Calcula o custo da manutenção
        }

        public double CalcularFalhas()
        {
            double custMaterial = (ValorKG / 1000) * Peso;
            return custMaterial * MediaFalhas; // Calcula o custo das falhas
        }

        public double CalcularAcabamento()
        {
            double custMaterial = (ValorKG / 1000) * Peso;
            return (custMaterial / 100) * Acabamento; // Calcula o custo do acabamento
        }

        // Método para calcular o custo total de produção
        public double CalcularCustoProducao()
        {
            // Soma todos os componentes do custo de produção e adiciona o custo de fixação da cola
            double custoProducao = CalcularMaterial() + CalcularEnergia() + CalcularManutencao() + CalcularFalhas() + CalcularAcabamento();
            return custoProducao + CustoFixacaoCola;
        }
    }

}
