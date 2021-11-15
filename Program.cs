using Strategy.Classe;
using Strategy.Classe.Operacoes;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calculadora = new Calcular();
            
            while(true)
            {

                //Informar os valores no console para operação 
                Console.WriteLine("Informe o primeiro valor: ");
                double valor1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor: ");
                double valor2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("--------------------");

                //Opção para selecionar 
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplicar");
               
                string opcao = Console.ReadLine();
                
                //Verificar qual operação o usuário selecionou 
                if(opcao == "1")
                {
                    calculadora.calcular = new Somar();
                    calculadora.CalcularOperacao(valor1, valor2);
                }else if(opcao == "2")
                {
                    try
                    {
                        calculadora.calcular = new Subtrair();
                        calculadora.CalcularOperacao(valor1, valor2);
                    }catch
                    {
                        Console.WriteLine("Erro na operação");
                    }
                }else if(opcao == "3")
                {
                    try
                    {
                        calculadora.calcular = new Dividir();
                        calculadora.CalcularOperacao(valor1, valor2);
                    }catch
                    {
                        Console.WriteLine("Erro na operação");
                    }
                }else if(opcao == "4")
                {
                    calculadora.calcular = new Multiplicar();
                    calculadora.CalcularOperacao(valor1, valor2);
                }
            }
        }
    }
}
