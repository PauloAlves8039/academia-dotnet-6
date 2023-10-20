internal class Program
{
    /*
     * 3 - Escreva uma função chamada TransporMatriz que recebe uma matriz como parâmetro e retorna a matriz transposta.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Retornando Matriz Transposta *****");

        int linhas = 3;
        int colunas = 3;

        int[,] matrizOriginal = new int[linhas, colunas];

        LerMatriz(matrizOriginal, linhas, colunas);

        Console.WriteLine("\n------ Resultado ------");

        Console.WriteLine("\nMatriz Original:");
        ImprimirMatriz(matrizOriginal);

        Console.WriteLine("\nMatriz Transposta:");
        int[,] matrizTransposta = TransporMatriz(matrizOriginal);

        ImprimirMatriz(matrizTransposta);

        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o valor para a posição [{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static void ImprimirMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    private static int[,] TransporMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int[,] matrizTransposta = new int[colunas, linhas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizTransposta[j, i] = matriz[i, j];
            }
        }
        return matrizTransposta;
    }
}