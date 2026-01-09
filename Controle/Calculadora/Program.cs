using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Write("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a opção (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.Write("Opção errada ");
                    break;

                case '+':
                    resultado = num1 + num2;
                    Console.Write("O resultado e: " + resultado);
                    break;

                case '-':
                    resultado = num1 - num2;
                    Console.Write("O resultado e: " + resultado);
                    break;

                case '*':
                    resultado = num1 * num2;
                    Console.Write("O resultado e: " + resultado);
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.Write("Não é possível dividir por 0");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.Write("O resultado e: " + resultado);
                    }
                    
                    break;

            }

            Console.Write("Continuar calculando (s / n) ");
            string opcao = Console.ReadLine();

            if (opcao == "s"|| opcao == "S")
            {
                goto Inicio;
            }

            Console.ReadKey();

        }
    }
}
