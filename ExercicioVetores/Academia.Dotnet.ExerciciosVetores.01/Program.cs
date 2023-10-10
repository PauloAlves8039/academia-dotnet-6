internal class Program
{
    /*
     * 1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre 
     * na tela a quantidade de números pares e ímpares.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Quantidade de Pares e Ímpares *****");

        int tamanhoDoVetor = 10;
        int[] vetor = new int[tamanhoDoVetor];
        int numerosPares = 0;
        int numerosImpares = 0;

        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            Console.Write($"Digite o valor para o elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        ContarParesEImpares(vetor, ref numerosPares, ref numerosImpares);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"Quantidade de números pares: {numerosPares}");
        Console.WriteLine($"Quantidade de números ímpares: {numerosImpares}");

        Console.ReadKey();
    }

    private static void ContarParesEImpares(int[] vetor, ref int pares, ref int impares)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

    }
}