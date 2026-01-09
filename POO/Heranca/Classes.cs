using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humanos.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humanos.Olhos");
        }
    }

    class Pessoa : Humano
    {
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }
    }

    class Homem : Pessoa
    {
        //public override void Olhos()
        //{
            //Console.WriteLine("Homem.Olhos");
       // }

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Olhos");
        }
    }
}
