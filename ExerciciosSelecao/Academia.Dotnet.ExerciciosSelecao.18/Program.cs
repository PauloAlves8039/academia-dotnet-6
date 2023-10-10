internal class Program
{
    /*
    * 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar o Maior Valor *****");

        Console.Write("Digite o primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro valor: ");
        double valor3 = double.Parse(Console.ReadLine());

        double maiorValor = EncontrarMaiorValor(valor1, valor2, valor3);

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine($"O maior valor entre {valor1}, {valor2} e {valor3} é => {maiorValor}.");

        Console.ReadKey();
    }

    private static double EncontrarMaiorValor(double a, double b, double c)
    {
        if (a >= b && a >= c)
        {
            return a;
        }
        else if (b >= a && b >= c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}