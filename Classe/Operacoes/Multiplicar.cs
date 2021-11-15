using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Classe.Operacoes
{
    public class Multiplicar : ICalculadora
    {
        public override double Operacao(double valor1, double valor2)
        {
            return valor1 * valor2;
        }
    }
}
