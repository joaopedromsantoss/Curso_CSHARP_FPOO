namespace CalculadoraAritmeticaSimples;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o numero 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o numero 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;
        int subtraction = number2 - number1;
        int division = number2 / number1;
        int multiplication = number2 * number1;
        int module = number2 % number1;

        Console.WriteLine("Valor soma: " + sum);
        Console.WriteLine("Valor subtração: " + subtraction);
        Console.WriteLine("Valor divisão: " + division);
        Console.WriteLine("Valor divisão: " + multiplication);

        Console.WriteLine("Valor divisão: " + module);

    }
}
