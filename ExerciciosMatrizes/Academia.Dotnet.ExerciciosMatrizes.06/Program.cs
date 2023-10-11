internal class Program
{
    /*
     * 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
     * Random random = new Random();
     * int randomNumber = random.Next(0, 100);
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Valor aleatório em Matriz *****");

        Console.WriteLine();

        Random random = new Random();

        int[,] matriz = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = random.Next(0, 100);
            }
        }

        Console.WriteLine("Matriz 4x4 com valores aleatórios:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        int maiorNumero = EncontrarMaiorNumero(matriz);

        Console.WriteLine("O maior número na matriz é: " + maiorNumero);

        Console.ReadKey();
    }

    private static int EncontrarMaiorNumero(int[,] matriz)
    {
        int maior = matriz[0, 0];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }

        return maior;
    }
}