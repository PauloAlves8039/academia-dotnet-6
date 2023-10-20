internal class Program
{
    /*
     * 5 - Crie uma função chamada SomaDiagonalPrincipal que recebe uma matriz quadrada como parâmetro 
     * e retorna a soma dos elementos na diagonal principal.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Somar Raiz Diagonal Principal *****");

        int linhas = 4;
        int colunas = 4;
        int[,] matriz = new int[linhas, colunas];

        LerMatriz(matriz, linhas, colunas);

        int soma = SomaDiagonalPrincipal(matriz);

        Console.WriteLine("------- Resultado -------");
        Console.WriteLine("A soma da diagonal principal é: {0}", soma);

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

    private static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, i];
        }
        return soma;
    }
}