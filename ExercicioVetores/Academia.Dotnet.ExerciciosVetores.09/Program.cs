internal class Program
{
    /*
     * 9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos, 
     * e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Ordenando Vetor em Ordem Crescente *****");

        int[] vetor = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        OrdenandoVetor(vetor);

        Console.WriteLine("\nVetor ordenado em ordem crescente:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        Console.ReadKey();
    }

    private static void OrdenandoVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            for (int j = i + 1; j < vetor.Length; j++)
            {
                if (vetor[i] > vetor[j])
                {
                    int temp = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = temp;
                }
            }
        }
    }
}