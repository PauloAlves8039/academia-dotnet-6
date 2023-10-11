using System;

class Program
{
    /*
     * 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, 
     * em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Média das Matrizes *****");

        int[,] matrizA = new int[4, 4];
        int[,] matrizB = new int[4, 4];

        LerMatriz(matrizA, "A");
        LerMatriz(matrizB, "B");

        int media = CalcularMedia(matrizA, matrizB);

        var (acimaA, abaixoA, naMediaA) = ContarElementos(matrizA, media);
        var (acimaB, abaixoB, naMediaB) = ContarElementos(matrizB, media);

        int contadorAcima = acimaA + acimaB;
        int contadorAbaixo = abaixoA + abaixoB;
        int contadorMedia = naMediaA + naMediaB;

        Console.WriteLine("A média é: " + media);
        Console.WriteLine("Quantidade acima da média é: " + contadorAcima);
        Console.WriteLine("Quantidade abaixo da média é: " + contadorAbaixo);
        Console.WriteLine("Quantidade na média é: " + contadorMedia);

        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz, string nomeDaMatriz)
    {
        Console.WriteLine($"Digite os valores da Matriz {nomeDaMatriz} ({matriz.GetLength(0)}x{matriz.GetLength(1)}):");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Informe o valor para a posição [{i}, {j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static int CalcularMedia(int[,] matrizA, int[,] matrizB)
    {
        int somaA = SomarMatriz(matrizA);
        int somaB = SomarMatriz(matrizB);
        int totalElementos = matrizA.GetLength(0) * matrizA.GetLength(1) + matrizB.GetLength(0) * matrizB.GetLength(1);

        return (somaA + somaB) / totalElementos;
    }

    private static int SomarMatriz(int[,] matriz)
    {
        int soma = 0;
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                soma += matriz[i, j];
            }
        }

        return soma;
    }

    private static (int, int, int) ContarElementos(int[,] matriz, int media)
    {
        int acima = 0, abaixo = 0, naMedia = 0;
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                int valor = matriz[i, j];

                if (valor > media)
                {
                    acima++;
                }
                else if (valor < media)
                {
                    abaixo++;
                }
                else
                {
                    naMedia++;
                }
            }
        }

        return (acima, abaixo, naMedia);
    }
}
