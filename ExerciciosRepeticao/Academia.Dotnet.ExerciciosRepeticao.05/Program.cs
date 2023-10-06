internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 5. Escreva um algoritmo para calcular o fatorial de um número.
        */
        
        Console.WriteLine("***** Calcular Fatorial *****");

        Console.Write("Digite um número inteiro não negativo: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("\n----- Resultado -----");

        long fatorial = CalcularFatorial(numero);

        Console.WriteLine($"O fatorial de {numero} é {fatorial}");

        Console.ReadKey();
    }

    private static long CalcularFatorial(int numero)
    {
        if (numero < 0)
        {
            Console.WriteLine("O número deve ser não negativo.");
            Environment.Exit(0);
        }

        if (numero == 0 || numero == 1)
        {
            return 1;
        }

        long resultado = 1;

        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}