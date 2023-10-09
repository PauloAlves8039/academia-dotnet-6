internal class Program
{
    // 17. Apresentar os quadrados dos números inteiros de 15 a 200.

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Apresentar os quadrados dos números inteiros de 15 a 200 *****");
        Console.WriteLine("------ Resultado ------");

        for (int i = 15; i <= 200; i++)
        {
            int quadrado = i * i;
            Console.WriteLine($"O quadrado de {i} é {quadrado}");
        }

        Console.ReadKey();
    }
}