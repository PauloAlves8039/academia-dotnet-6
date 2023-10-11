internal class Program
{
    /*
     * 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Exibir Elementos de Matriz Diagonal *****");

        int[,] matriz = new int[4, 4];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Informe o valor para a posição [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nElementos da Diagonal Principal:");

        ImprimirMatrizDiagonal(matriz);

        Console.ReadKey();
    }

    private static void ImprimirMatrizDiagonal(int[,] matriz)
    {
        for (int i = 0; i < 4; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }
    }
}