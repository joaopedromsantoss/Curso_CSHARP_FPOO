using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t  = new Teste();
            t.Nome = "Pedro";
            t.Idade = 25;

            Console.WriteLine(t.Nome + " " + t.sobrenome);
            Console.WriteLine(t.Idade);

        }
    }
}
