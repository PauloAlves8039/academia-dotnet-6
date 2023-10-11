internal class Program
{
    /*
     * 11) Leia uma matriz A de tipo double de dimenção 3x3, 
     * crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Dividindo Elementos da Matriz *****");

        double[,] matriz = new double[3, 3];
        double[,] matrizResultado = new double[3, 3];

        LerMatriz(matriz); 
        CalcularMatriz(matriz, matrizResultado); 

        Console.WriteLine("\nMatriz A:");
        ImprimirMatriz(matriz);

        Console.WriteLine("\n-------- Resultado --------");
        ImprimirMatriz(matrizResultado);

        Console.ReadKey();
    }

    private static void LerMatriz(double[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o valor para A[{i}][{j}]: ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }
    }

    private static void CalcularMatriz(double[,] matriz, double[,] matrizResultado)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                double somaIndices = i + j;

                if (somaIndices != 0)
                {
                    matrizResultado[i, j] = matriz[i, j] / somaIndices;
                }
                else
                {
                    matrizResultado[i, j] = 0.0;
                }
            }
        }
    }

    private static void ImprimirMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}