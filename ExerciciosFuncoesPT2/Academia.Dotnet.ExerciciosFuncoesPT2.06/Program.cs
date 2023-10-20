internal class Program
{
    /*
     * 6 - Escreva uma função chamada MediaColunaMatriz que recebe uma matriz e um número de coluna como parâmetros, 
     * e retorna a soma dos elementos nessa coluna.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Somar Elementos da Coluna *****");
        
        Console.Write("Informe o número de linhas da matriz: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.Write("Informe o número de colunas da matriz: ");
        int colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];

        Console.WriteLine();

        LerMatriz(matriz, linhas, colunas);

        Console.WriteLine();

        Console.Write("Informe o número da coluna para calcular a soma: ");
        int numeroDaColuna = int.Parse(Console.ReadLine());

        int soma = MediaColunaMatriz(matriz, numeroDaColuna);

        Console.WriteLine("--------- Resultado ---------");

        Console.WriteLine($"A soma dos elementos na coluna {numeroDaColuna} é: {soma}");

        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz, int linhas, int colunas)
    {
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Informe o valor para a posição ({i + 1}, {j + 1}): ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static int MediaColunaMatriz(int[,] matriz, int numeroColuna)
    {
        int soma = 0;
        int linhas = matriz.GetLength(0);

        for (int i = 0; i < linhas; i++)
        {
            soma += matriz[i, numeroColuna];
        }

        return soma;
    }
}