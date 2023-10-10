internal class Program
{
    /*
     * 16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
	 * A união de X com Y
	 * A diferença entre X e Y
	 * A interseção entre X e Y
     * Escreva o vetor resultado de cada uma das operações.
    */

    private static void Main()
    {
        Console.WriteLine("***** Exibir Operações em Vetores *****");

        int[] X = new int[10];
        int[] Y = new int[10];

        Console.WriteLine("Digite 10 valores para o vetor X:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"X[{i}] = ");
            X[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDigite 10 valores para o vetor Y:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Y[{i}] = ");
            Y[i] = int.Parse(Console.ReadLine());
        }

        int[] uniao = VerificarUniao(X, Y);
        int[] diferenca = VerificarDiferenca(X, Y);
        int[] intersecao = VerificarIntersecao(X, Y);

        Console.WriteLine("\nUnião de X e Y:");
        ExibirVetor(uniao);

        Console.WriteLine("\nDiferença entre X e Y:");
        ExibirVetor(diferenca);

        Console.WriteLine("\nInterseção entre X e Y:");
        ExibirVetor(intersecao);

        Console.ReadKey();
    }

    private static int[] VerificarUniao(int[] vetor1, int[] vetor2)
    {
        int[] resultado = new int[20];

        for (int i = 0; i < 10; i++)
        {
            resultado[i] = vetor1[i];
        }

        for (int i = 0; i < 10; i++)
        {
            bool valorEncontrado = false;

            for (int j = 0; j < 10; j++)
            {
                if (vetor2[i] == resultado[j])
                {
                    valorEncontrado = true;
                    break;
                }
            }

            if (!valorEncontrado)
            {
                resultado[10 + i] = vetor2[i];
            }
        }

        return resultado;
    }

    private static int[] VerificarDiferenca(int[] vetor1, int[] vetor2)
    {
        int[] resultado = new int[10];

        for (int i = 0; i < 10; i++)
        {
            bool valorEncontrado = false;

            for (int j = 0; j < 10; j++)
            {
                if (vetor1[i] == vetor2[j])
                {
                    valorEncontrado = true;
                    break;
                }
            }

            if (!valorEncontrado)
            {
                resultado[i] = vetor1[i];
            }
        }

        return resultado;
    }

    private static int[] VerificarIntersecao(int[] vetor1, int[] vetor2)
    {
        int[] resultado = new int[10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (vetor1[i] == vetor2[j])
                {
                    resultado[i] = vetor1[i];
                    break;
                }
            }
        }

        return resultado;
    }

    private static void ExibirVetor(int[] vetor)
    {
        foreach (var elemento in vetor)
        {
            if (elemento != 0)
            {
                Console.Write($"{elemento} ");
            }
        }
        Console.WriteLine();
    }
}
