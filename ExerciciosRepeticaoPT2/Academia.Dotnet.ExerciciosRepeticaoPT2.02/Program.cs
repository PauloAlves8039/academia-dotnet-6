internal class Program
{
    /*
    * 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
    * informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
    * Exemplo:
    * Digite um número inteiro positivo: 8
    * Numero digitado: 8
    * Números inteiros pares entre 1 e 8: 2, 4, 6.
 
    * Deseja informar outro número (s/n)? S
 
    * Digite um número inteiro positivo: 12
    * Numero digitado: 20
    * Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
    * Deseja informar outro número (s/n)? N 
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar Número *****");

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