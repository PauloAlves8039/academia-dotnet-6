internal class Program
{
    /*
     * 7) Crie uma função que determine se um número é primo ou não.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar se Número é Primo *****");

        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        bool ehPrimo = VerificarNumeroPrimo(numero);

        if (ehPrimo)
        {
            Console.WriteLine($"O número {numero} é primo!");
        }
        else 
        {
            Console.WriteLine($"O número {numero} não é primo!");
        }

        Console.ReadKey();
    }

    private static bool VerificarNumeroPrimo(int numero) 
    {
        if (numero <= 1) 
        {
            return false;
        }

        for (int i = 2; i < numero; i++) 
        {
            if (numero % i == 0) 
            {
                return false;
            }
        }

        return true;
    }
}