internal class Program
{
    /*
     * 14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal 
     * (da esquerda para a direita) são os mesmos da diagonal secundária (direita pra esquerda).
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar Elementos Diagonais *****");

        int[,] matriz = new int[5, 5];

        LerMatriz(matriz);

        Console.WriteLine("\n-------- Resultado --------");
        if (VerificarElementosDiagonais(matriz))
        {
            Console.WriteLine("Os elementos das diagonais principais e secundárias são iguais.");
        }
        else
        {
            Console.WriteLine("Os elementos das diagonais principais e secundárias são diferentes.");
        }

        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Elemento [{(i + 1)} , {(i + 1)}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static bool VerificarElementosDiagonais(int[,] matriz)
    {
        for (int i = 0; i < 5; i++)
        {
            if (matriz[i, i] != matriz[i, 4 - i])
            {
                return false;
            }
        }
        return true;
    }
}