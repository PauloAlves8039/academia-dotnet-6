internal class Program
{
    /*
     * 17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, 
     * ou seja,o menor elemento da linha onde se encontra o maior elemento da matriz. 
     * Escreva também a linha e a coluna onde foi encontrado.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Maior e Menor Elemento em Matriz (10 x 10)");

        int[,] matriz = CriarMatrizAleatoria(10, 10);

        int linhaMaior;
        int colunaMaior;
        EncontrarMaiorElemento(matriz, out linhaMaior, out colunaMaior);

        int linhaMenor;
        int colunaMenor;
        EncontrarMenorElemento(matriz, out linhaMenor, out colunaMenor);

        ImprimirMatriz(matriz);

        Console.WriteLine("\n------------------------ Resultado ------------------------");
        Console.WriteLine($"O maior elemento da matriz é {matriz[linhaMaior, colunaMaior]} na linha {linhaMaior}, coluna {colunaMaior}.");
        Console.WriteLine($"O menor elemento da matriz é {matriz[linhaMenor, colunaMenor]} na linha {linhaMenor}, coluna {colunaMenor}.");

        Console.ReadKey();
    }

    static int[,] CriarMatrizAleatoria(int linhas, int colunas)
    {
        int[,] matriz = new int[linhas, colunas];
        Random random = new Random();

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = random.Next(1, 101);
            }
        }

        return matriz;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        Console.WriteLine("Matriz:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void EncontrarMaiorElemento(int[,] matriz, out int linha, out int coluna)
    {
        int maiorElemento = matriz[0, 0];
        linha = 0;
        coluna = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (matriz[i, j] > maiorElemento)
                {
                    maiorElemento = matriz[i, j];
                    linha = i;
                    coluna = j;
                }
            }
        }
    }

    static void EncontrarMenorElemento(int[,] matriz, out int linha, out int coluna)
    {
        int menorElemento = matriz[0, 0];
        linha = 0;
        coluna = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (matriz[i, j] < menorElemento)
                {
                    menorElemento = matriz[i, j];
                    linha = i;
                    coluna = j;
                }
            }
        }
    }
}