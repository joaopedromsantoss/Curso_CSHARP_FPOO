using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Teste
    {
        // Definição de um campo
        private string nome;
        public string sobrenome { get; } = "Oliveira";
        private int idade;

        // Definição de uma propriedade
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Menorde idade");
                }
                else
                {
                    idade = value;
                }
            }
        }

        public void Apresetar()
        {
            if (nome != "")
            {
                Console.WriteLine("Bem vindo: " + nome);
            }

        }
    }
}
