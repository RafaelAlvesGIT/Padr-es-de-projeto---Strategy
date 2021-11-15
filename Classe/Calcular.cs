
using Strategy.Classe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Classe
{
   public class Calcular
    {
        public ICalculadora calcular { get; set; }
        public void CalcularOperacao(double valor1, double valor2)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Resultado: " + calcular.Operacao(valor1, valor2));
        }
    }
}
