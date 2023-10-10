internal class Program
{
    /*
     * 6.Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. 
     * Exemplo:
      * a. lê: |7|40|3|9|21|0|63|31|7|22|
      * b. escreve: |22|7|31|63|0|21|9|3|40|7|
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Ler Vetor em Ordem Contrária *****");

        int tamanhoDoVetor = 10;
        int[] numeros = new int[tamanhoDoVetor];

        Console.WriteLine("Digite dez números:");

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