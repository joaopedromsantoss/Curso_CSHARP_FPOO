using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 
            int resultado = 10 + 2;
            #endregion

            #region Incremento e decremento
            int num1 = 10;

            //num1 = num1 + 1;
            //num1++;
            //++num1;
            //--num1;
            //num1--;
            #endregion


            #region concantenação

            string nome = "Gabriel" + "Artigas";
            #endregion

            #region Atribuicao
            int num2 = 10;

            //num2 += 20;
            //num2 -= 2;
            // num2 *= 10;
            // num2 /= 2;
            //num2%= 10;
            #endregion

            string nome2 = "João";
            nome2 += " Santos";

            bool res = 100 == 50;

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
