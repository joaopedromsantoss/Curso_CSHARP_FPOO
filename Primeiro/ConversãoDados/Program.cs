using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversãoDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 100;
            ushort n2;

            n2 = n1;

            float n3 = 1250.45f;
            double n4 = n3;

            int numero = 'C';


            ushort num1 = 100;
            byte num2 = (byte)num1;

            float num3 = 125.55f;
            int num4 = (int)num3;

            char letra = (char)97;


            string txtnumero = "1985";
            int num = int.Parse(txtnumero);

            byte byt = byte.Parse("120");

            double doub = double.Parse("45,00");

            float flo = float.Parse("45,00");

            string texto = Convert.ToString(2500);

            double teste = Convert.ToDouble(false);

            int int32 = Convert.ToInt32('c');

            Console.WriteLine(byt);

        }
    }
}
