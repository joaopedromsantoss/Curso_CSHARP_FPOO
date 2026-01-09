using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 15;

            if(valor > 5)
            {
                Console.WriteLine("Condiçao verdadeira");
            } 
            else if (valor >= 5 && valor < 10)
            {
                Console.WriteLine("Condiçao falsa");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Condiçao falsa");
            }
            else
            {

            }


            int numero = 15;

            if (numero > 5)
            {
                Console.WriteLine("numero maior que 5");

                if (numero % 2 == 0)
                {
                    Console.WriteLine("também é par");
                }
                else
                {
                    Console.WriteLine("não é par");
                }
            }

            int num = 10;
            string menssagem = "";

            menssagem = numero > 5 ? "Maior que 5 " : "Menor que 5 ";

            Console.ReadKey();
        }
    }
}
