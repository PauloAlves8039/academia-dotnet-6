internal class Program
{
    /*
     * 9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
     * Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Pesquisar Número na Matriz *****");

        int[,] matriz = new int[3, 3];
        int numeroProcurado;

        Console.WriteLine("Digite os elementos da matriz 3x3:");
        LerMatriz(matriz);

        Console.Write("\nDigite o número que deseja procurar na matriz: ");
        numeroProcurado = int.Parse(Console.ReadLine());

        bool numeroEncontrado = ProcuraNumeroNaMatriz(matriz, numeroProcurado);

        Console.WriteLine("\n-------- Resultado --------");
        ValidarNumero(numeroEncontrado);
        
        Console.ReadKey();
    }

    private static void LerMatriz(int[,] matriz)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Matriz[{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static bool ProcuraNumeroNaMatriz(int[,] matriz, int numeroProcurado)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == numeroProcurado)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private static bool ValidarNumero(bool numero) 
    {
        bool numeroEncontrado = numero;

        if (numeroEncontrado)
        {
            Console.WriteLine("O número existe na matriz.");
        }
        else
        {
            Console.WriteLine("Número inexistente na matriz.");
        }

        return numeroEncontrado;
    }
}