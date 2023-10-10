internal class Program
{
    /*
     * 10.Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, 
     * substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Substituir Valores Nulos Por Dois *****");

        int[] vetorOriginal = new int[20];
        int[] vetorResultado = new int[20];

        Console.WriteLine("Digite 20 números inteiros:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                vetorOriginal[i] = numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                i--;
            }
        }

        SubstituirNulosPorDois(vetorOriginal, vetorResultado);

        Console.WriteLine("\n-------- Resultado --------");

        Console.WriteLine("\nVetor Original:");
        ImprimirVetor(vetorOriginal);

        Console.WriteLine("\nVetor Resultado:");
        ImprimirVetor(vetorResultado);

        Console.ReadKey();
    }

    private static void SubstituirNulosPorDois(int[] vetorOriginal, int[] vetorResultado)
    {
        for (int i = 0; i < vetorOriginal.Length; i++)
        {
            vetorResultado[i] = (vetorOriginal[i] == 0) ? 2 : vetorOriginal[i];
        }
    }

    private static void ImprimirVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{vetor[i]} ");
        }
    }
}