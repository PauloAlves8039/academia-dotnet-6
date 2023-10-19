internal class Program
{
    /*
     * 8) Ler um número inteiro e passar por parâmetro para uma função e 0, se o número é par, ou 1, se o número é ímpar.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar se Número é Par ou Ímpar *****");

        Console.Write("Digite um valor inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        int resultado = VerificarParImpar(numero);

        ImprimirResultado(numero, resultado);

        Console.ReadKey();
    }

    private static void ImprimirResultado(int numero, int resultado) 
    {
        if (resultado == 0)
        {
            Console.WriteLine($"O número {numero} é: par!");
        }
        else
        {
            Console.WriteLine($"O número {numero} é: ímpar!");
        }
    }

    private static int VerificarParImpar(int numero)
    {
        return (numero % 2 == 0) ? 0 : 1;
    }
}