internal class Program
{
    /*
     * 2) Fazer programa que tenha duas funções. 
     * i) para ler um vetor de 10 elementos (variável global) e 
     * ii) para verificar e apresentar a quantidadede elementos pares que este vetor possui.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar quantidade de Pares *****");

        int tamanhoDoVetor = 10;
        int[] vetor = new int[tamanhoDoVetor];

        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            Console.Write($"Digite o valor para o elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int quantidadeDePares = VerificarQuantidadeDePares(vetor);

        Console.WriteLine("---------- Resultado ----------");
        Console.WriteLine($"O vetor possui {quantidadeDePares} elementos pares!");

        Console.ReadKey();
    }

    private static int VerificarQuantidadeDePares(int[] vetor) 
    {
        int quantidade = 0;

        for (int i = 0; i < vetor.Length; i++) 
        {
            if (vetor[i] % 2 == 0) 
            {
                quantidade++;
            }
        }
        return quantidade;
    }
}