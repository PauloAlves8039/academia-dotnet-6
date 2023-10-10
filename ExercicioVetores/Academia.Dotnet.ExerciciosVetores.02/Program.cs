internal class Program
{
    /*
     * 2.Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize 
     * a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Somando Dois Vetores *****");

        int tamanho = 20;

        int[] vetor1 = new int[tamanho];
        int[] vetor2 = new int[tamanho];

        Console.WriteLine("Digite os valores para o primeiro vetor:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDigite os valores para o segundo vetor:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        int[] resultado = SomarVetores(vetor1, vetor2);

        Console.WriteLine("\nResultado da soma dos elementos:");
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Elemento {i + 1}: {resultado[i]}");
        }

        Console.ReadKey();
    }

    private static int[] SomarVetores(int[] vetor1, int[] vetor2)
    {
        int tamanho = vetor1.Length;
        int[] resultado = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            resultado[i] = vetor1[i] + vetor2[i];
        }

        return resultado;
    }
}