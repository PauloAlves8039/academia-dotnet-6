internal class Program
{
    /*
    * 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Exibir Valor em Ordem Crescente *****");

        Console.Write("Digite o primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro valor: ");
        double valor3 = double.Parse(Console.ReadLine());

        double maiorValor = EncontrarMaiorValor(valor1, valor2, valor3);

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine($"O maior valor entre {valor1}, {valor2} e {valor3} é => {maiorValor}.");

        Console.WriteLine("\nValores em ordem crescente:");
        MostrarValoresEmOrdemCrescente(valor1, valor2, valor3);

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

    private static void MostrarValoresEmOrdemCrescente(double a, double b, double c)
    {
        double[] valores = { a, b, c };
        Array.Sort(valores);
        Console.WriteLine($"{valores[0]}, {valores[1]}, {valores[2]}");
    }
}