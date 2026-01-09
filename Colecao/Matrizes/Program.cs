using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] resultado = new int[2, 2];

            Console.WriteLine("Preencha a matriz 1: ");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(" 1. Posição [ " + linha + "][" + coluna + "]");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write(" 1. Posição [ " + linha + "][" + coluna + "]");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("resultado da multiplicacao da matriz 1 e 2");
            

        }
    }
}
