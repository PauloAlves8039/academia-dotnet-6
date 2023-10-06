internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
         * (informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
         * Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

         * Exemplo:
         * Digite um número inteiro positivo: -8
         * Valor incorreto!
         * Digite um número inteiro positivo: 8
         * Numero digitado: 8
         * Números inteiros pares entre 1 e 8: 2, 4, 6.
        */

        int numero = ValidarNumero();

        Console.WriteLine("\n----- Resultado -----");
        Console.WriteLine($"Número digitado: {numero}");
        Console.Write("Números inteiros pares entre 1 e {0}: ", numero);

        for (int i = 2; i <= numero; i += 2)
        {
            if (i != 2)
            {
                Console.Write(", ");
            }
            Console.Write(i);
        }

        Console.ReadKey();
    }

    private static int ValidarNumero()
    {
        int numero;
        bool entradaValida = false;

        do
        {
            Console.Write("Digite um número inteiro positivo: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero) && numero > 0)
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Valor incorreto! Digite um número inteiro positivo válido.");
            }
        } while (!entradaValida);

        return numero;
    }

}