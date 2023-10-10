internal class Program
{
    /*
    * 7. Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
    * um usuário. Apresente o resultado.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Contador de Pares e Ìmpares *****");

        int numerosPares = ContarNumerosPares();
        int numerosImpares = 20 - numerosPares;

        Console.WriteLine("\n------ Resultado ------");
        Console.WriteLine($"Quantidade de números pares: {numerosPares}");
        Console.WriteLine($"Quantidade de números ímpares: {numerosImpares}");

        Console.ReadKey();
    }

    private static int ContarNumerosPares()
    {
        int numerosPares = 0;

        for (int i = 1; i <= 20; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                numerosPares++;
            }
        }

        return numerosPares;
    }
}