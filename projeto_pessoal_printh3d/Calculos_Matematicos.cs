using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pessoal_printh3d
{
    class Calculos_Matematicos
    {
        public double valorKG;
        public double peso;
        public double kwh;
        public double consumo;
        public double tempo;
        public double depreHora;
        public double mediaFalhas;
        public double acabamento;

        public double cMaterial()
        {
            return (valorKG / 1000) * peso; ;
        }


        public double cEnergia()
        {
            return ((kwh / 1000) * consumo) * (tempo / 60);
        }

    

        public double cManutencao()
        {
            return (tempo * depreHora);
        }


        public double cFalhas()
        {
            double custMaterial = (valorKG / 1000) * peso;
            return custMaterial*mediaFalhas;
        }


        public double cAcabamento()
        {
            double custMaterial = (valorKG / 1000) * peso;
            return (custMaterial /100)* acabamento;
        }

        public double cSomaProd(double a,double b,double c,double d,double e,double f)
        {
            return a + b + c + d + e + f;
        }

    }
}
