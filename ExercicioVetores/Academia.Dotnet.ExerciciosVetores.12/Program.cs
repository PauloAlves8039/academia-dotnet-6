internal class Program
{
    /*
     * 12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, 
     * existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Pesquisar Número no Vetor *****");

        int tamanhoDoVetor = 10;
        int[] vetor = new int[tamanhoDoVetor];

        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            Console.Write($"Digite o valor para a posição {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite um número para verificar no vetor: ");
        int numeroN = int.Parse(Console.ReadLine());

        Console.WriteLine("\n-------- Resultado --------");
        PesquisarNumeroNoVetor(vetor, numeroN);

        Console.ReadKey();
    }

    static void PesquisarNumeroNoVetor(int[] vetor, int numero)
    {
        bool numeroEncontrado = false;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numero)
            {
                Console.WriteLine($"O número {numero} foi encontrado na posição {i + 1}");
                numeroEncontrado = true;
            }
        }

        if (!numeroEncontrado)
        {
            Console.WriteLine($"O número {numero} não existe no vetor!");
        }
    }
}