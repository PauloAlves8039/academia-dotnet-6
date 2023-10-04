using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 11) Escreva um algoritmo para ler o número de eleitores de um município, 
         * o número de votos brancos, nulos e válidos. 
         * Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
        */

        Console.WriteLine("***** Total de Eleitores *****");

        int totalEleitores, votosBrancos, votosNulos, votosValidos;

        Console.Write("Informe o número total de eleitores: ");
        totalEleitores = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos em branco: ");
        votosBrancos = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos nulos: ");
        votosNulos = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de votos válidos: ");
        votosValidos = int.Parse(Console.ReadLine());

        double percentualBrancos = CalcularPercentual(votosBrancos, totalEleitores);
        double percentualNulos = CalcularPercentual(votosNulos, totalEleitores);
        double percentualValidos = CalcularPercentual(votosValidos, totalEleitores);

        ExibirResultados(percentualBrancos, percentualNulos, percentualValidos);

        Console.ReadKey();
    }

    private static double CalcularPercentual(int votos, int totalEleitores)
    {
        return (double)votos / totalEleitores * 100;
    }

    private static void ExibirResultados(double percentualBrancos, double percentualNulos, double percentualValidos)
    {
        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Percentual de votos em branco: {percentualBrancos.ToString("F2", CultureInfo.InvariantCulture)}%");
        Console.WriteLine($"Percentual de votos nulos: {percentualNulos.ToString("F2", CultureInfo.InvariantCulture)}%");
        Console.WriteLine($"Percentual de votos válidos: {percentualValidos.ToString("F2", CultureInfo.InvariantCulture)}%");
    }
}