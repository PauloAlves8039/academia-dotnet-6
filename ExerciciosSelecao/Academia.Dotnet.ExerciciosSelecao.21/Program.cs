using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada 
         * (metros, centímetros, polegadas ou pés) e uma unidade de medida de saída usando um menu com o comando switch case. 
         * O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse valor para a unidade de saída selecionada.
        */

        Console.WriteLine("***** Conversos de Unidade de Medidas *****");

        Console.WriteLine("Selecione a unidade de medida de entrada:");
        Console.WriteLine("1 - Metros");
        Console.WriteLine("2 - Centímetros");
        Console.WriteLine("3 - Polegadas");
        Console.WriteLine("4 - Pés");

        Console.Write("Digite o número da unidade de medida de entrada: ");
        int unidadeEntrada = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Selecione a unidade de medida de saída:");
        Console.WriteLine("1 - Metros");
        Console.WriteLine("2 - Centímetros");
        Console.WriteLine("3 - Polegadas");
        Console.WriteLine("4 - Pés");

        Console.Write("Digite o número da unidade de medida de saída: ");
        int unidadeSaida = int.Parse(Console.ReadLine());

        Console.Write("\nDigite o valor de entrada: ");
        double valorEntrada = double.Parse(Console.ReadLine());

        double valorSaida = ConversorDeUnidades(valorEntrada, unidadeEntrada, unidadeSaida);

        Console.WriteLine($"O valor convertido é: {valorSaida.ToString("F2", CultureInfo.InvariantCulture)} na unidade de medida de saída selecionada.");

        Console.ReadKey();
    }

    private static double ConversorDeUnidades(double valorEntrada, int unidadeEntrada, int unidadeSaida)
    {
        double valorConvertido = 0;

        switch (unidadeEntrada)
        {
            case 1:
                valorConvertido = ConversorDeMetros(valorEntrada, unidadeSaida);
                break;
            case 2:
                valorConvertido = ConversorDeCentimetros(valorEntrada, unidadeSaida);
                break;
            case 3:
                valorConvertido = ConversorDePolegadas(valorEntrada, unidadeSaida);
                break;
            case 4:
                valorConvertido = ConversorDePes(valorEntrada, unidadeSaida);
                break;
        }

        return valorConvertido;
    }

    private static double ConversorDeMetros(double valorEntrada, int unidadeSaida)
    {
        switch (unidadeSaida)
        {
            case 1:
                return valorEntrada;
            case 2:
                return valorEntrada * 100;
            case 3:
                return valorEntrada * 39.3701;
            case 4:
                return valorEntrada * 3.28084;
            default:
                return 0;
        }
    }

    private static double ConversorDeCentimetros(double valorEntrada, int unidadeSaida)
    {
        switch (unidadeSaida)
        {
            case 1:
                return valorEntrada / 100;
            case 2:
                return valorEntrada;
            case 3:
                return valorEntrada / 2.54;
            case 4:
                return valorEntrada / 30.48;
            default:
                return 0;
        }
    }

    private static double ConversorDePolegadas(double valorEntrada, int unidadeSaida)
    {
        switch (unidadeSaida)
        {
            case 1:
                return valorEntrada / 39.3701;
            case 2:
                return valorEntrada * 2.54;
            case 3:
                return valorEntrada;
            case 4:
                return valorEntrada / 12;
            default:
                return 0;
        }
    }

    private static double ConversorDePes(double valorEntrada, int unidadeSaida)
    {
        switch (unidadeSaida)
        {
            case 1:
                return valorEntrada / 3.28084;
            case 2:
                return valorEntrada * 30.48;
            case 3:
                return valorEntrada * 12;
            case 4:
                return valorEntrada;
            default:
                return 0;
        }
    }
}