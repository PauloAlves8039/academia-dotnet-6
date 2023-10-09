internal class Program
{
    /*
     * 16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
     * multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
     * (N*3; N*3*3; N*3*3*3; etc).
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Multiplicação Sucessiva *****");

        Console.Write("Digite um número N (<= 50): ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("------ Resultado ------");

        if (numero <= 50)
        {
            int produto = numero;
            MultiplicandoValorSucessivo(produto);
        }
        else
        {
            Console.WriteLine("O número N deve ser menor ou igual a 50.");
        }

        Console.ReadKey();
    }

    private static void MultiplicandoValorSucessivo(int produto) 
    {
        while (produto < 250) 
        {
            Console.WriteLine(produto);
            produto *= 3;
        }
    }
}