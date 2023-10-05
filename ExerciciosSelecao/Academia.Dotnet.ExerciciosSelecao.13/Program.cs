using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
         * seu peso ideal, utilizando as seguintes fórmulas:
         * Para homens: (72.7 * h) - 58
         * Para mulheres: (62.1 * h) - 44.7
         */

        Console.WriteLine("***** Calculadora de Peso Ideal *****");

        Console.Write("Informe sua altura (em metros): ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Informe seu sexo (M para masculino, F para feminino): ");
        string generoInformado = Console.ReadLine();
        char genero = char.ToUpper(generoInformado[0]);

        Console.WriteLine("\n----- Resultado -----");

        CalcularPesoIdeal(altura, genero);

        Console.ReadKey();
    }

    private static double CalcularPesoIdeal(double altura, char genero) 
    {
        double pesoIdeal = 0.0;

        if (genero == 'M')
        {
            pesoIdeal = (72.7 * altura) - 58.0;
            Console.WriteLine($"\nSeu peso ideal é: {pesoIdeal.ToString("F2", CultureInfo.InvariantCulture)} kg");
        }
        else if (genero == 'F')
        {
            pesoIdeal = (62.1 * altura) - 44.7;
            Console.WriteLine($"\nSeu peso ideal é: {pesoIdeal.ToString("F2", CultureInfo.InvariantCulture)} kg");
        }
        else 
        {
            Console.WriteLine("\nGênero inválido. Use M para masculino ou F para feminino.");
        }

        return Math.Round(pesoIdeal, 2);
    }
}