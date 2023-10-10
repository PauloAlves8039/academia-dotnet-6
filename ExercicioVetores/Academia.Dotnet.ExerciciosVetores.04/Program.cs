using System;

internal class Program
{
    /*
     * 4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, 
     * colocando o resultado em um terceiro vetor. Mostre o vetor resultante.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Multiplicando Elementos do Mesmo Índice *****");

        int tamanho = 10;

        int[] vetor1 = new int[tamanho];
        int[] vetor2 = new int[tamanho];
        int[] resultado = new int[tamanho];

        Console.WriteLine("Digite os valores para o primeiro vetor:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Vetor1[{i}] = ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os valores para o segundo vetor:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Vetor2[{i}] = ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        resultado = MultiplicarVetores(vetor1, vetor2);

        Console.WriteLine("Vetor Resultante:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Resultado[{i}] = {resultado[i]}");
        }

        Console.ReadKey();
    }

    private static int[] MultiplicarVetores(int[] vetor1, int[] vetor2)
    {
        int tamanho = vetor1.Length;
        int[] resultado = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
        }

        return resultado;
    }
}
