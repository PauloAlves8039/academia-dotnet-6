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

        Console.Write("\nDigite um número para verificar no vetor: ");
        int numeroN = int.Parse(Console.ReadLine());

        Console.WriteLine("\n---------- Resultado ----------");
        bool resultadoDaPesquisa = PesquisarNumeroNoVetor(vetor, numeroN);

        if (resultadoDaPesquisa)
        {
            Console.WriteLine($"O número {numeroN} foi encontrado no vetor!");
        }
        else
        {
            Console.WriteLine($"O número {numeroN} não existe no vetor!");
        }

        Console.ReadKey();
    }

    private static bool PesquisarNumeroNoVetor(int[] vetor, int numero)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numero)
            {
                return true;
            }
        }

        return false; 
    }
}