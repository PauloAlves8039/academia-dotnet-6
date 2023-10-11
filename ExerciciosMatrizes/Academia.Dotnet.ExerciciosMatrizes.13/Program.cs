internal class Program
{
    /*
     * 13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) 
     * e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da diagonal secundária.
    */

    private static void Main(string[] args)
    {
        int[,] matriz = new int[5, 5];
        
        Console.WriteLine("Informe os elementos da matriz 5x5:");
        LerMatriz(matriz);
        
        int somaDiagonalPrincipal = CalcularSomaDiagonalPrincipal(matriz);
        int somaDiagonalSecundaria = CalcularSomaDiagonalSecundaria(matriz);

        Console.WriteLine("\n-------- Resultado --------");
        ImprimirResultado(somaDiagonalPrincipal, somaDiagonalSecundaria);

        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write("Elemento [" + (i + 1) + "," + (j + 1) + "]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static int CalcularSomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, i];
        }
        return soma;
    }

    private static int CalcularSomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, matriz.GetLength(0) - 1 - i];
        }
        return soma;
    }

    private static void ImprimirResultado(int somaDiagonalPrincipal, int somaDiagonalSecundaria)
    {
        if (somaDiagonalPrincipal == somaDiagonalSecundaria)
        {
            Console.WriteLine("A soma da diagonal principal é igual à soma da diagonal secundária.");
        }
        else
        {
            Console.WriteLine("A soma da diagonal principal não é igual à soma da diagonal secundária.");
        }
    }
}