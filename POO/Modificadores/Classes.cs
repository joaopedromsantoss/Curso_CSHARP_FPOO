using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Teste
    {
        private string nome;
        public string sobrenome;

        private void Metodo() { }
        public void Exwcutar() { }
    }

    class Humano
    {
        protected string nome;
        private string sobrenome;
        internal int idade;
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 0;
        }
    }
}
