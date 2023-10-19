using System.Globalization;

internal class Program
{
    /*
     * 6) Escreva uma função que calcule a média de um vetor de 10 números.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Média de Vetor *****");

        int tamanhoDoVetor = 10;
        double[] vetor = new double[tamanhoDoVetor];

        LerVetor(vetor, tamanhoDoVetor);

        double mediaDoVetor = CalcularMediaDeVetor(vetor);

        Console.WriteLine("----- Resultado -----");

        Console.WriteLine($"A média do vetor é: {mediaDoVetor.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    private static void LerVetor(double[] vetor, int tamanhoDoVetor) 
    {
        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            Console.Write($"Digite o valor para o elemento {i + 1}: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }
    }

    private static double CalcularMediaDeVetor(double[] vetor) 
    {
        double soma = 0;

        for (int i = 0; i < vetor.Length; i++) 
        {
            soma += vetor[i];
        }

        return soma / vetor.Length;
    }
}