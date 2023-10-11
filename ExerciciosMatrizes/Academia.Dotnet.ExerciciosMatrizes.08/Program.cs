internal class Program
{
    /*
     * 8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Exibir Números em Ordem Direta e Inversa *****");

        int[,] matriz = new int[4, 4];

        Console.WriteLine("Digite os valores da matriz 4x4:");
        LerMatriz(matriz);

        Console.WriteLine("\n-------- Resultado --------");

        Console.WriteLine("Matriz na ordem direta:");
        ImprimirMatrizDireta(matriz);

        Console.WriteLine("Matriz na ordem inversa:");
        ImprimirMatrizInversa(matriz);

        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz)
    {
        for (int linha = 0; linha < 4; linha++)
        {
            for (int coluna = 0; coluna < 4; coluna++)
            {
                Console.Write($"Digite o valor para matriz[{linha}][{coluna}]: ");
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static void ImprimirMatrizDireta(int[,] matriz)
    {
        for (int linha = 0; linha < 4; linha++)
        {
            for (int coluna = 0; coluna < 4; coluna++)
            {
                Console.Write($"{matriz[linha, coluna]} ");
            }
            Console.WriteLine();
        }
    }

    private static void ImprimirMatrizInversa(int[,] matriz)
    {
        for (int linha = 3; linha >= 0; linha--)
        {
            for (int coluna = 3; coluna >= 0; coluna--)
            {
                Console.Write($"{matriz[linha, coluna]} ");
            }
            Console.WriteLine();
        }
    }
}