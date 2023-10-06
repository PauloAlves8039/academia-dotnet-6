using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 1. Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n 
         * pessoas e calcular a média das idades.
        */

        Console.WriteLine("***** Calcular a Média das Idades *****");

        Console.Write("\nDigite o número de pessoas: ");
        int numero = int.Parse(Console.ReadLine());

        int somaIdades = 0;

        for (int i = 1; i <= numero; i++)
        {
            Console.Write($"Digite a idade da pessoa {i}: ");
            int idade = int.Parse(Console.ReadLine());
            somaIdades += idade;
        }

        Console.WriteLine("\n----- Resultado -----");

        if (numero > 0)
        {
            CalcularMediaDeIdade(numero, somaIdades);
        }
        else
        {
            Console.WriteLine("Não há pessoas para calcular a média!");
        }

        Console.ReadKey();
    }

    private static double CalcularMediaDeIdade(int numero, int idades) 
    {
        double mediaIdades = (double)idades / numero;
        Console.WriteLine($"A média das idades é: {mediaIdades.ToString("F2", CultureInfo.InvariantCulture)} anos!");
        
        return mediaIdades;
    }
}