internal class Program
{
    /*
     * 15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, 
     * e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, 
     * o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, 
     * por exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Passando Vetor em Ordem Inversa *****");

        int tamanhoDoVetor = 20;
        int[] numeros = new int[tamanhoDoVetor];

        Console.WriteLine("Digite vinte números:");

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

        Console.WriteLine("Conteúdo do primeiro vetor:");
        ImprimirVetor(numeros);

        Console.WriteLine("\nConteúdo do segundo vetor (invertido):");
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