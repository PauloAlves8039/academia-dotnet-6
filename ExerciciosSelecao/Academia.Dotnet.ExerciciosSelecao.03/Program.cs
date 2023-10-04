using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, 
         * e escrever na tela os que são superiores à média.
        */

        Console.WriteLine("***** Exibir Média Superior *****");

        int[] valores = new int[4];

        for (int i = 0; i < 4; i++)
        {
            valores[i] = ObterValor("Digite o valor #" + (i + 1) + ": ");
        }

        double media = CalcularMedia(valores);

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine();

        ExibirValoresSuperiores(valores, media);

        Console.ReadKey();
    }
    private static int ObterValor(string mensagem)
    {
        Console.Write(mensagem);
        return int.Parse(Console.ReadLine());
    }

    private static double CalcularMedia(int[] valores)
    {
        int soma = 0;

        foreach (int valor in valores)
        {
            soma += valor;
        }

        return (double)soma / valores.Length;
    }

    private static void ExibirValoresSuperiores(int[] valores, double media)
    {
        Console.WriteLine("\nValores superiores à média ({0}):", media.ToString("F2", CultureInfo.InvariantCulture));

        for (int i = 0; i < 4; i++)
        {
            if (valores[i] > media)
            {
                Console.WriteLine(valores[i].ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}