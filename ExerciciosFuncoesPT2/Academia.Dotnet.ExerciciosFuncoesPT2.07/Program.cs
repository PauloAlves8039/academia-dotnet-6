internal class Program
{
    /*
     * 7 - Crie uma função chamada VerificarNumeroPrimo que recebe um vetor de números inteiros como parâmetro 
     * e retorna verdadeiro se pelo menos um número primo estiver presente no vetor, e falso caso contrário.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar Número Primo *****");

        Console.Write("Quantos números você deseja inserir no vetor? ");
        int tamanho = int.Parse(Console.ReadLine());

        int[] vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write("Digite o número " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("---------- Resultado ----------");

        if (VerificarNumeroPrimo(vetor))
        {
            Console.WriteLine("Pelo menos um número primo está presente no vetor.");
        }
        else
        {
            Console.WriteLine("Nenhum número primo está presente no vetor.");
        }

        Console.ReadKey();
    }

    private static bool VerificarNumeroPrimo(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (EhPrimo(vetor[i]))
            {
                return true;
            }
        }
        return false;
    }


    private static bool EhPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}