internal class Program
{
    /*
     * 7) Leia duas matrizes A e B com 3x3 elementos. 
     * Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Subtrair Elementos de Duas Marizes *****");

        int[,] matrizA = new int[3, 3];
        int[,] matrizB = new int[3, 3];
        int[,] matrizC = new int[3, 3];

        Console.WriteLine("Digite os elementos da matriz A (3x3):");
        LerMatriz(matrizA);

        Console.WriteLine("Digite os elementos da matriz B (3x3):");
        LerMatriz(matrizB);

        SubtrairMatrizes(matrizA, matrizB, matrizC);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine("A matriz C (A - B) é:");
        ImprimirMatriz(matrizC);

        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static void SubtrairMatrizes(int[,] matrizA, int[,] matrizB, int[,] matrizC)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
            }
        }
    }

    private static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}