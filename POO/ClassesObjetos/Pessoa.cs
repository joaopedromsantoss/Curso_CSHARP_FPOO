using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Pessoa
    {
        // atributos
        public string nome;
        public string sobrenome;
        public int anoNasc;

        // Método simples
        public void Complementar() 
        {
            Console.WriteLine("Ola eu sou " + nome + " " + sobrenome);
        }

    }
}
