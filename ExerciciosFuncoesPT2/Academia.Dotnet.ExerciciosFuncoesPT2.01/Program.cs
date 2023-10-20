internal class Program
{
    /*
     * 1 - Na teoria dos Sistemas, define-se como elemento minimax de uma matriz, 
     * o menor elemento da linha em que se encontra o maior elemento da matriz. 
     * Escreva um programa que lê uma matriz [10 X 10] e em uma função encontre e 
     * mostre o elemento minimax e sua posição na matriz.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Encontra Elemento Minimax *****");

        int linhas = 10;
        int colunas = 10;
        int[,] matriz = new int[linhas, colunas];

        LerMatriz(matriz, linhas, colunas);

        int linhaMax = 0; 
        int colunaMax = 0;
        int maximo = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j];
                    linhaMax = i;
                    colunaMax = j;
                }
            }
        }

        int menorElemento = EncontrarMenorElemento(matriz, linhas, colunas);

        Console.WriteLine("------- Resultado -------");
        Console.WriteLine("O maior elemento (elemento minimax) é " + maximo);
        Console.WriteLine("Posição na matriz: [" + linhaMax + "," + colunaMax + "]");
        Console.WriteLine("O menor elemento na matriz é " + menorElemento);

        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz, int linhas, int colunas) 
    {
        Console.WriteLine("Digite os valores da matriz 10x10:");

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Digite o elemento [{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static int EncontrarMenorElemento(int[,] matriz, int linhas, int colunas)
    {
        int menorElemento = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] < menorElemento)
                {
                    menorElemento = matriz[i, j];
                }
            }
        }

        return menorElemento;
    }
}