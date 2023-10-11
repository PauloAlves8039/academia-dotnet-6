internal class Program
{
    /*
     * 1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. 
     * A 2ª coluna, some 10 aos elementos da 1ª coluna. 
     * Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Exibindo Operação em Matriz *****");

        int[,] matriz = new int[5, 3];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o valor para a posição [{i}, 0]: ");
            matriz[i, 0] = int.Parse(Console.ReadLine());
        }

        SomandoValoresDosElementos(matriz);
        DuplicandoValoresDosElementos(matriz);
        ImprimirMatriz(matriz);

        Console.ReadKey();
    }

    private static void SomandoValoresDosElementos(int[,] matriz) 
    {
        for (int i = 0; i < 5; i++)
        {
            matriz[i, 1] = matriz[i, 0] + 10;
        }
    }

    private static void DuplicandoValoresDosElementos(int[,] matriz)
    {
        for (int i = 0; i < 5; i++)
        {
            matriz[i, 2] = matriz[i, 0] * 2;
        }
    }

    private static void ImprimirMatriz(int[,] matriz)
    {
        Console.WriteLine("\nMatriz resultante:");
        
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}