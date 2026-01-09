using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            Carro carro = new Carro();
            carro.Cor = "Preto";
            carro.Marca = "Chevrolet";
            carro.Acelerar();
            carro.Parar();
            Console.WriteLine("Cor: " + carro.Cor);
            Console.WriteLine("Marca: " + carro.Marca);


            Bicicleta bicicleta = new Bicicleta();
            bicicleta.Cor = "Branca";
            bicicleta.Marca = "Caloi";
            bicicleta.Acelerar();
            bicicleta.Parar();
            Console.WriteLine("Cor: " + bicicleta.Cor);
            Console.WriteLine("Marca: " + bicicleta.Marca);
            #endregion

            Humano humano = new Humano();
            Pessoa pessoa = new Pessoa();
            Homem homem = new Homem();

            Console.WriteLine("\nHumano ");
            humano.Olhos();
            humano.Cabelos();

            Console.WriteLine("\nPessoa");
            pessoa.Olhos();
            pessoa.Cabelos();

            Console.WriteLine("\nHomem ");
            homem.Olhos();
            homem.Cabelos();

            Console.ReadKey();
            
        }
    }
}
