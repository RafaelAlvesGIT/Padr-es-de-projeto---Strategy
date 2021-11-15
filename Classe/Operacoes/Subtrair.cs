using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Classe.Operacoes
{
    public class Subtrair : ICalculadora
    {
        public override double Operacao(double valor1, double valor2)
        {
            if (valor2 > valor1)
            {
                throw new InvalidOperationException();
            }

            return valor1 - valor2;
        }
    }
}
