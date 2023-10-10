internal class Program
{
    /*
    * 2. Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar Maior Valor *****");

        int maiorNumero = int.MinValue;
        int numero = 0;

        Console.WriteLine();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite o " + i + "º número: ");
            numero = int.Parse(Console.ReadLine());

            VerificarMaiorNumero(numero, maiorNumero);
        }

        Console.WriteLine("\n----- Resultado -----");

        int resultadoExercicio2 = VerificarMaiorNumero(numero, maiorNumero);
        Console.WriteLine($"O maior número é: {resultadoExercicio2}");

        Console.ReadKey();
    }

    private static int VerificarMaiorNumero(int numero, int maiorNumero) 
    {
        int resultado = maiorNumero;

        if (numero > resultado) 
        {
            resultado = numero;
        }

        return resultado;
    }
}