internal class Program
{
    private static void Main(string[] args)
    {
        do
        {
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

            Console.Write("\nDeseja informar outro número (s/n)? ");
        } while (Console.ReadLine().ToLower() == "s");

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