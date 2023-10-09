internal class Program
{
    // Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Somatório de Valores *****");
        Console.WriteLine("------ Resultado ------");

        int soma = 0;

        for (int i = 1; i <= 500; i++)
        {
            if (i % 2 == 0)
            {
                soma += i; 
            }
        }

        Console.WriteLine($"O somatório dos valores pares entre 1 e 500 é: {soma}");

        Console.ReadKey();
    }
}