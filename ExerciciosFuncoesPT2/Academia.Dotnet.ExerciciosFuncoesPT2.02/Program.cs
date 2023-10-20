using System.Globalization;

internal class Program
{
    /*
     * 2 - Escreva uma função chamada CalcularMedia que recebe um vetor de números, 
     * a informação se o usuário deseja escolher os pares ou os impares, 
     * e retorna a média dos valores conforme a escolha do usuário.
    */

    private static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        int[] numeros = new int[tamanho];
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Deseja calcular a média dos números pares (P) ou ímpares (I)? Digite 'P' ou 'I': ");
        char escolha = char.ToUpper(Console.ReadKey().KeyChar);

        Console.WriteLine("\n------ Resultado ------");

        if (escolha == 'P')
        {
            double mediaNumerosPares = CalcularMedia(numeros, true);
            Console.WriteLine($"A média dos números pares é: {mediaNumerosPares.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else if (escolha == 'I')
        {
            double mediaNumeroImpares = CalcularMedia(numeros, false);
            Console.WriteLine($"A média dos números ímpares é: {mediaNumeroImpares.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            Console.WriteLine("Escolha inválida. Digite 'P' para pares ou 'I' para ímpares.");
        }

        Console.ReadKey();
    }

    private static double CalcularMedia(int[] numeros, bool escolherPares)
    {
        int soma = 0;
        int contador = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeros[i];

            if ((escolherPares && numero % 2 == 0) || (!escolherPares && numero % 2 != 0))
            {
                soma += numero;
                contador++;
            }
        }

        if (contador == 0)
        {
            Console.WriteLine($"Não há números {(escolherPares ? "pares" : "ímpares")} no vetor.");
            return 0.0;
        }

        return (double)soma / contador;
    }
}