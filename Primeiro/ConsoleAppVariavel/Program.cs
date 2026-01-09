namespace ConsoleAppVariavel
{
    internal class Program
    {
        enum Notas 
        { 
            Minimo = 10, 
            Media = 20,
            Maxima = 30
        }

        struct Pessoa 
        {
            public string nome;

            public int idade;

            public double altura;
        }
        static void Main(string[] args)
        {
            #region Numéricos Integrais
            //Integrador assinado
            sbyte num1 = 10;
            short num2 = 20;
            int num3 = 30;
            long num4 = 40L;

            // Integrador sem sinal
            byte num8 = 10;
            ushort num5 = 20;
            uint num6 = 30;
            ulong num7 = 40L;
            #endregion

            #region Numéicos reais
            float real = 100.75f;
            double real2 = 100.25;
            decimal real3 = 75363.47m;
            #endregion

            char letra = 'a';

            bool verfica = false;

            string texto = "Aprendendo C#";

            var valor = 10;

            object obj = 300;

            obj = "String";

            const double pi = 3.1415;

            Notas mediaAluno = Notas.Media;

            Pessoa p1 = new Pessoa();

            p1.altura = 1.90;
            p1.idade = 18;
            p1.nome = "Lauro";

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                idade = 18,
                altura = 1.80
            };
        }
    }
}
