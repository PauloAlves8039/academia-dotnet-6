using System.Globalization;

internal class Program
{
    /*
     * 5) Desenvolva uma função que converta uma temperatura em graus Celsius para Fahrenheit.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Converter Celsius para Fahrenheit *****");

        Console.Write("Digite o valor de Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double conversorFahrenheit = ConverterCelsiusParaFahrenheit(celsius);

        Console.WriteLine("----- Resultado -----");
        
        Console.WriteLine($"A conversão da temperatura Celsius para Fahrenheit é: {conversorFahrenheit.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    private static double ConverterCelsiusParaFahrenheit(double celsius) 
    {
        double fahrenheit = (celsius * 9 / 5) + 32;
        return fahrenheit;
    }
}