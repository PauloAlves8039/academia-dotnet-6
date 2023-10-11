internal class Program
{
    /*
     * 2) Solicite ao usuário, preencher uma Matriz 3x3

     * Informe ao usuário:
     * A soma dos elementos de cada linha
	 * -Ex: Linha 1: 30
	     Linha 2: 17
     * A soma dos elementos de cada coluna
	 * -Ex: Coluna 1: 23
	     Coluna 2: 36
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Somando Elementos da Matriz *****");

        int[,] matriz = new int[3, 3];

        Console.WriteLine("Preencha a matriz 3x3:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite o elemento [{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\n-------- Resultado --------");
        SomandoElementosDasLinhas(matriz);
        SomandoElementosDasColunas(matriz);

        Console.ReadKey();
    }

    private static void SomandoElementosDasLinhas(int[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < 3; j++)
            {
                somaLinha += matriz[i, j];
            }
            Console.WriteLine($"Soma dos elementos da Linha {i + 1}: {somaLinha}");
        }
    }

    private static void SomandoElementosDasColunas(int[,] matriz)
    {
        for (int j = 0; j < 3; j++)
        {
            int somaColuna = 0;
            for (int i = 0; i < 3; i++)
            {
                somaColuna += matriz[i, j];
            }
            Console.WriteLine($"Soma dos elementos da Coluna {j + 1}: {somaColuna}");
        }
    }
}