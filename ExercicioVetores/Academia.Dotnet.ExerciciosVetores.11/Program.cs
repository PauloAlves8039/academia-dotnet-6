internal class Program
{
    /*
     * 11.	Escreva um programa que leia valores em um vetor de 5 posições. 
     * Escrever os elementos do vetor e após escrever os elementos na ordem inversa.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Exibir Vetor em Ordem Inversa *****");

        int tamanhoDoVetor = 5;
        int[] numeros = new int[tamanhoDoVetor];

        Console.WriteLine("Digite cinco números:");

        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            Console.Write($"Número {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out numeros[i]) == false)
            {
                Console.WriteLine("Por favor, digite um número válido.");
                i--;
            }
        }

        Console.WriteLine("\n-------- Resultado --------");

        Console.WriteLine("Números na ordem crescente:");
        ImprimirVetor(numeros);

        Console.WriteLine("\nNúmeros na ordem decrescente:");
        ImprimirVetorEmOrdemDecrescente(numeros);

        Console.ReadKey();
    }

    private static void ImprimirVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"{vetor[i]} ");
        }
    }

    private static void ImprimirVetorEmOrdemDecrescente(int[] vetor)
    {
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write($"{vetor[i]} ");
        }
    }
}