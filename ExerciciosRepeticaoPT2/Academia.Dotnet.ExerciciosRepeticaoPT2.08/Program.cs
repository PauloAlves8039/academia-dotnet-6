internal class Program
{
    /*
     * 8. Faça um programa em VS que solicite um numero inteiro.
     * Se o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
     * Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
    */

    private static void Main(string[] args)
    {
        bool repetir = true;

        while (repetir)
        {
            Console.Write("Digite um número inteiro: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                VerificarNumeroPar(numero);
            }
            else
            {
                Console.WriteLine("O valor inserido não é um número inteiro.");
            }

            Console.Write("Deseja repetir o programa? (S/N): ");
            string resposta = Console.ReadLine().Trim();

            if (resposta.ToLower() == "n")
            {
                repetir = false;
            }

            Console.WriteLine();
        }
    }

    private static bool VerificarNumeroPar(int numero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
            return true;
        }
        else 
        {
            Console.WriteLine("O número é ímpar.");
            return false;
        }
    }
}