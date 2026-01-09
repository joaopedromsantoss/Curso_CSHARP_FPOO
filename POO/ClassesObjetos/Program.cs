using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "João";
            pessoa.sobrenome = "Santos";
            pessoa.anoNasc = 2007;

            Pessoa pessoa2 = new Pessoa()
            {
                nome = "Arthur",
                sobrenome = "Lima",
                anoNasc = 2000
            };

            Console.WriteLine("Pessoa 1: " + pessoa.nome);
            Console.WriteLine("Pessoa 1: " + pessoa.sobrenome);
            Console.WriteLine("Pessoa 1: " + pessoa.anoNasc);
            pessoa.Complementar();

            Console.WriteLine("Pessoa 2: " + pessoa2.nome);
            Console.WriteLine("Pessoa 2: " + pessoa2.sobrenome);
            Console.WriteLine("Pessoa 2: " + pessoa2.anoNasc);

            Console.ReadKey();

        }
    }

}
