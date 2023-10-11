internal class Program
{
    /*
     * 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. 
     * Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Transpor uma Matriz *****");

        int[,] matriz3x4 = LerMatriz(3, 4);
        int[,] matriz4x3 = TransporMatriz(matriz3x4);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine("Matriz 4x3 transposta:");
        ImprimirMatriz(matriz4x3);

        Console.ReadKey();
    }

    private static int[,] LerMatriz(int linhas, int colunas)
    {
        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Informe o valor para a posição ({i + 1},{j + 1}): ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    matriz[i, j] = valor;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    j--;
                }
            }
        }

        return matriz;
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
}