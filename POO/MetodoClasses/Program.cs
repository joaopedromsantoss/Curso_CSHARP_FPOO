using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodo m = new Metodo();
            m.Somar(10, 20);
            m.Apresentar("João", 18);

            int valor1 = 100;
            int valor2 = 100;

            m.AumentarValor(valor1);
            m.AumentarRef(ref valor2);

            Console.WriteLine("Valor 1: " + valor1);
            Console.WriteLine("Valor 2: " + valor2);

            string nomeCompleto = m.MontaNome("João", "Santos");
            int codChar = m.CodigoChar('a');
            double pi = m.ValorPI();

            Console.WriteLine("Nome completo: " + nomeCompleto);
            Console.WriteLine("valor caracter: " + codChar);
            Console.WriteLine("PI: " + pi);

            m.Complementar("João");
            m.Complementar("João", 10);

            Console.ReadKey();

            
            
       }
    }
}
