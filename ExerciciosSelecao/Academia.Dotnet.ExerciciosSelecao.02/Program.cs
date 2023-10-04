internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
        */

        Console.WriteLine("***** Verificar Par ou Ímpar *****");

        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        VerificarPaiOuImpar(numero);

        Console.ReadKey();
    }

    private static void VerificarPaiOuImpar(int numero) 
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é par.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ímpar.");
        }
    }
}