using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Classe
{
    public abstract class ICalculadora
    {
        public abstract double Operacao(double valor1, double valor2);
    }
}
