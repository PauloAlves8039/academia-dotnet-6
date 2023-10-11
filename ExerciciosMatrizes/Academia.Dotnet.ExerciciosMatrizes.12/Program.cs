internal class Program
{
    /*
     * 12) Escreva um programa que leia os valores de uma matriz 4x3, 
     * e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Exibir Soma dos Índices *****");

        int[,] matriz = new int[4, 3];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("Digite o valor da posição ({0}, {1}): ", i, j);
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nValores com soma de índices par:");
        VerificarSomaDosIndices(matriz);

        Console.ReadKey();
    }

    private static void VerificarSomaDosIndices(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int somaIndices = i + j;

                if (somaIndices % 2 == 0)
                {
                    Console.WriteLine($"({i}, {j}): {matriz[i, j]}");
                }
            }
        }
    }
}