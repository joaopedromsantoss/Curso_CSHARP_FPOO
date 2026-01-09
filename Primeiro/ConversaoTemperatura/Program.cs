using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double c, f, k;

            Console.WriteLine("CONVERSOR DE TEMPERATURAS ");
            Console.Write("Insira a temperatura em celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");

            f = (c * 9 / 5) + 32;

            k = c + 273.15;

            Console.WriteLine(c + " graus celsius = " + f + " graus fahrenheit ");

            Console.WriteLine(c + " graus celsius = " + k + " graus kelvin ");
            Console.ReadKey();
        }
    }
}
