using System.Globalization;

internal class Program
{
    /*
     * 3) Desenvolva uma função que calcule a média de três números fornecidos como argumentos.
     */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Média de Números *****");

        Console.WriteLine("Digite três números:");
        double numero1 = double.Parse(Console.ReadLine());
        double numero2 = double.Parse(Console.ReadLine());
        double numero3 = double.Parse(Console.ReadLine());

        double media = CalcularMedia(numero1, numero2, numero3);

        Console.WriteLine("----- Resultado -----");
        Console.WriteLine($"A média dos números é: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    private static double CalcularMedia(double numero1, double numero2, double numero3) 
    {
        double media = (numero1 + numero2 + numero3) / 3;
        return media;
    }
}