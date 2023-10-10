using System.Globalization;

internal class Program
{
    /*
    * 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
    * (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
    * consumido para percorrê-la (medido em l).
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Consumo Médio de Combustível *****");

        Console.Write("Informe a distância total percorrida (em quilômetros): ");
        double distanciaTotal = double.Parse(Console.ReadLine());

        Console.Write("Informe o volume de combustível consumido (em litros): ");
        double volumeCombustivel = double.Parse(Console.ReadLine());

        double resultadoExercicio5 = CalculandoConsumoDeCombustivel(distanciaTotal, volumeCombustivel);

        Console.WriteLine("---------- Resultado ----------");

        Console.WriteLine();
        Console.WriteLine($"Consumo médio do combustível é: {resultadoExercicio5.ToString("F2", CultureInfo.InvariantCulture)} km/l");

        Console.ReadKey();
    }

    private static double CalculandoConsumoDeCombustivel(double distancia, double volume)
    {
        double consumoMedio = distancia / volume;
        return consumoMedio;
    }
}