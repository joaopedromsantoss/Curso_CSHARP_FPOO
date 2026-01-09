using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o Peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nValor IMC: " + valorIMC + "-> Valor abaixo do Peso");
            }
            else if (valorIMC >= 20 && valorIMC <= 24)
            {
                Console.WriteLine("\nValor IMC: " + valorIMC + "-> Valor normal do Peso");
            }
            else if (valorIMC >= 25 && valorIMC <= 29)
            {
                Console.WriteLine("\nValor IMC: " + valorIMC + "-> Valor acima do Peso");
            }
            else if (valorIMC >= 29 && valorIMC <= 34)
            {
                Console.WriteLine("\nValor IMC: " + valorIMC + "-> Obeso");
            }
            else 
            {
                Console.WriteLine("\nValor IMC: " + valorIMC + "-> Muito Obeso");
            }

            Console.ReadKey();
        }
    }
}
