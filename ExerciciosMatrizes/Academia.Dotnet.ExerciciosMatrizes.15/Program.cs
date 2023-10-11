internal class Program
{
    /*
     * 15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Somar Duas Matrizes *****");

        int linhas = 4;
        int colunas = 4;

        int[,] matriz1 = new int[linhas, colunas];
        int[,] matriz2 = new int[linhas, colunas];
        int[,] matrizSoma = new int[linhas, colunas];

        Console.WriteLine("Digite os valores da primeira matriz:");
        LerMatriz(matriz1, linhas, colunas);

        Console.WriteLine("Digite os valores da segunda matriz:");
        LerMatriz(matriz2, linhas, colunas);
        
        SomaMatrizes(matriz1, matriz2, matrizSoma);

        Console.WriteLine("Matriz resultante da soma:");
        ExibirMatriz(matrizSoma);

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

    private static void SomaMatrizes(int[,] matriz1, int[,] matriz2, int[,] matrizSoma)
    {
        for (int i = 0; i < matriz1.GetLength(0); i++)
        {
            for (int j = 0; j < matriz1.GetLength(1); j++)
            {
                matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }
    }

    private static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

}