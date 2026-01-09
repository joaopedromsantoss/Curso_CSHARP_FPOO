using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoClasses
{
    internal class Metodo
    {
        // Metodo simples
        //public void Complementar()
        //{
        //    Console.WriteLine("Hellow World");
       // }

        // Metodo com parametro
        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma e: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é: " + nome + "e tenho a idade " + idade + " anos");
        }

        // Passagem de parametros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("O valor e: " + valor);
        }

        // Passagem de parametros por referencia
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("O valor e: " + valor);
        }

        // Método com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            //string nomeCompleto = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caracter)
        {
            return caracter;
        }

        public double ValorPI()
        {
            return 3.14;
        }

        // Sobrecarga de Metodos
        public void Complementar(string nome)
        {
            Console.WriteLine("Ola " + nome);
         }

        public void Complementar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia " + nome : "Boa tarde " + nome;
            Console.WriteLine(mensagem);
        }

    }
}
