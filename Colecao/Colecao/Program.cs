using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores
            int[] numeros = new int[5];

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            
            string[] nomes = new string[3];

            nomes[0] = "Gabriel";
            nomes[1] = "Danny";
            nomes[2] = "Ana";
            

            string[] nomes2= 
            { 
                "Gabriel", 
                "Danny", 
                "Arthur" 
            };
            #endregion

            int[,] numeros2 = new int[2, 3];

            numeros2[0, 0] = 10;
            numeros2[0, 1] = 20;
            numeros2[0, 2] = 30;

            numeros2[1, 0] = 40;
            numeros2[1, 1] = 50;
            numeros2[1, 2] = 60;

            string[,] nomes3 =
            {
                {"Gabriel", "Danny", "Arthur" },
                {"Flávia", "João", "Laura" }
            };

            Console.WriteLine(numeros[3]);
            Console.WriteLine(nomes[2]);
            Console.Write("[" + numeros2[0,0] + "]");
            Console.Write("[" + numeros2[0,1] + "]");
            Console.Write("[" + numeros2[0,2] + "]");
            Console.Write("[" + numeros2[1,0] + "]");
            Console.Write("[" + numeros2[1,1] + "]");
            Console.Write("[" + numeros2[1,2] + "]");
            Console.ReadKey();
        }
    }
}
