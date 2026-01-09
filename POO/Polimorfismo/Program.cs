using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma formaTriangulo = new Triangulo();
            Forma formaCriculo = new Circulo();
            Forma formaRetangulo = new Retangulo();

            Console.WriteLine("\nTriangulo");
            formaTriangulo.Desenhar(); 
            Console.WriteLine("\nCirculo");
            formaCriculo.Desenhar();
            Console.WriteLine("\nRetangulo");
            formaRetangulo.Desenhar();


            Console.ReadKey();
        }
    }
}
