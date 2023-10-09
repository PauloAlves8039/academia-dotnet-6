internal class Program
{
    // 14. Mostrar as potências de 2 variando de 0 a 10.

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Mostrar as potências de 2 variando de 0 a 10 *****");
        Console.WriteLine("------ Resultado ------");
        int resultado = 1;

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"2^{i} = {resultado}");
            resultado *= 2;
        }

        Console.ReadKey();
    }
}