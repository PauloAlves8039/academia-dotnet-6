using System.Globalization;

internal class Program
{
    /*
    * 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
    * A fórmula da conversão é F=(9*C+160)/5.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Converter Celsius Para Fahrenheit *****");

        Console.Write("Informe o valor Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        Console.WriteLine("----- Resultado -----");

        double resultadoExercicio1 = ConverterCelsiusParaFahrenheit(celsius);

        Console.WriteLine($"A conversão para Fahrenheit é: {resultadoExercicio1.ToString("F2", CultureInfo.InvariantCulture)} °F");

        Console.ReadKey();
    }

    private static double ConverterCelsiusParaFahrenheit(double celsius)
    {
        double fahrenheit = (9 * celsius + 160) / 5;
        return fahrenheit;
    }
}