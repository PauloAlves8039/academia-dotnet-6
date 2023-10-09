internal class Program
{
    // 12. Apresentar o total da soma dos cem primeiros números inteiros.

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Soma de Números Inteiros *****");
        Console.WriteLine("------ Resultado ------");

        int soma = 0;

        
        for (int i = 1; i <= 100; i++)
        {
            soma += i;
        }

        Console.WriteLine($"A soma dos cem primeiros números inteiros é: {soma}");

        Console.ReadKey();
    }
}