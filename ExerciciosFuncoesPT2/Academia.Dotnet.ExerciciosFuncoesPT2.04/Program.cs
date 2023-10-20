internal class Program
{
    /*
     * 4 - Escreva uma função chamada MultiplicarMatrizes que recebe duas matrizes 
     * como parâmetros e retorna a matriz resultante da multiplicação.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Multiplicar Matrizes *****");

        int[,] matrizA = new int[3, 2];
        int[,] matrizB = new int[2, 2];

        Console.WriteLine("Informe os valores da primeira matriz (3x2):");
        LerMatriz(matrizA);

        Console.WriteLine("Informe os valores da segunda matriz (2x2):");
        LerMatriz(matrizB);

        int[,] resultado = MultiplicarMatrizes(matrizA, matrizB);

        Console.WriteLine("\nResultado da multiplicação das matrizes:");
        ImprimirMatriz(resultado);

        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Informe o valor para a posição ({i + 1}, {j + 1}): ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static int[,] MultiplicarMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] resultado = new int[matrizA.GetLength(0), matrizB.GetLength(1)];

        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizB.GetLength(1); j++)
            {
                resultado[i, j] = 0;
                for (int k = 0; k < matrizB.GetLength(0); k++)
                {
                    resultado[i, j] += matrizA[i, k] * matrizB[k, j];
                }
            }
        }

        return resultado;
    }

    private static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}