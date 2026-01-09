namespace EstruturaCondicional;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um numero");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = number % 2;

        if (result == 0)
        {
            Console.WriteLine("O resultado é par");
        } 
        else
        {
            Console.WriteLine("O resultado é ímpar");
        }
    }
}
