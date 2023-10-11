internal class Program
{
    /*
     * 5) Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Soma de Duas Matrizes 2x3 *****");

        int linhas = 2;
        int colunas = 3;

        double[,] matriz1 = new double[linhas, colunas];
        double[,] matriz2 = new double[linhas, colunas];

        Console.WriteLine("Digite os valores da primeira matriz:");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Matriz1[{i}][{j}]: ");
                matriz1[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        Console.WriteLine("Digite os valores da segunda matriz:");
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Matriz2[{i}][{j}]: ");
                matriz2[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        double[,] somaMatrizes = new double[linhas, colunas];
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                somaMatrizes[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        Console.WriteLine("A soma das duas matrizes é:");
        ImprimirMatriz(somaMatrizes, linhas, colunas);

        Console.ReadKey();
    }

    static void ImprimirMatriz(double[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"{matriz[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}