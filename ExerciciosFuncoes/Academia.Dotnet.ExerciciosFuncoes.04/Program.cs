internal class Program
{
    /*
     * 4) Escreva uma função que calcule o fatorial de um número inteiro positivo.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calculando Fatorial *****");

        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = CalcularFatorial(numero);

        Console.WriteLine("\n----- Resultado -----");

        if (numero < 0)
        {
            Console.WriteLine($"O fatorial de {numero} não está definindo para valor negativo!");
        }
        else 
        {
            Console.WriteLine($"O fatorial de {numero} é: {resultado}");
        }

        Console.ReadKey();
    }

    private static int CalcularFatorial(int numero) 
    {
        int fatorial = 1;

        if (numero == 0) 
        {
            return 1;
        }

        for (int i = 1; i <= numero; i++) 
        {
            fatorial *= i;
        }

        return fatorial;
    }
}