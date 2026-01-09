using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ciclo - While
            int valor = 0;

            while(valor < 10)
            {
                Console.WriteLine("O valor e: " + valor);
                valor++;
            }
            #endregion

            #region Ciclo - Do While
            int numero = 0;

            do
            {
                Console.WriteLine("O valor e " + numero);
                numero++;
            } while (numero < 10);
            #endregion

            #region Ciclo - For
            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                Console.WriteLine("I = " + i + "j = " + j);
            }
            #endregion


            string[] nomes = { "Gabriel", "Danny", "Arthur" };

            foreach(string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }
            Console.ReadKey();
        }
    }
}
