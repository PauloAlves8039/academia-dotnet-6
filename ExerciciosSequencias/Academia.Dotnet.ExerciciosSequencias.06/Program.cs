using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        /*
         * 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
         * isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
         * de IPI (única) a ser acrescentada.
        */

        Console.WriteLine("***** Calculo de Parafusos *****");

        Console.WriteLine("Informe os dados para o Parafuso A:");
        Console.Write("Código: ");
        int codigoA = int.Parse(Console.ReadLine());
        Console.Write("Quantidade: ");
        int quantidadeA = int.Parse(Console.ReadLine());
        Console.Write("Valor Unitário: ");
        double valorUnitarioA = double.Parse(Console.ReadLine());
        Console.Write("IPI: ");
        double ipiA = double.Parse(Console.ReadLine());

        ObterCodigo(codigoA);
        ObterQuantidade(quantidadeA);
        ObterValor(valorUnitarioA);
        ObterIPI(ipiA);

        Console.WriteLine();

        Console.WriteLine("Informe os dados para o Parafuso B:");
        Console.Write("Código: ");
        int codigoB = int.Parse(Console.ReadLine());
        Console.Write("Quantidade: ");
        int quantidadeB = int.Parse(Console.ReadLine());
        Console.Write("Valor Unitário: ");
        double valorUnitarioB = double.Parse(Console.ReadLine());
        Console.Write("IPI: ");
        double ipiB = double.Parse(Console.ReadLine());

        ObterCodigo(codigoB);
        ObterQuantidade(quantidadeB);
        ObterValor(valorUnitarioB);
        ObterIPI(ipiB);

        Console.WriteLine();

        double valorTotalParafusoA = CalcularValorTotal(quantidadeA, valorUnitarioA, ipiA);
        double valorTotalParafusoB = CalcularValorTotal(quantidadeB, valorUnitarioB, ipiB);

        Console.WriteLine();

        Console.WriteLine("----- Resultado -----");
        ExibirResumo(codigoA, quantidadeA, valorUnitarioA, ipiA, valorTotalParafusoA);
        ExibirResumo(codigoB, quantidadeB, valorUnitarioB, ipiB, valorTotalParafusoB);

        Console.ReadKey();
    }

    private static int ObterCodigo(int codigo)
    {
        int resultado = codigo;
        return resultado;
    }

    private static int ObterQuantidade(int quantidade)
    {
        int resultado = quantidade;
        return resultado;
    }

    private static double ObterValor(double valor)
    {
        double resultado = valor;
        return resultado;
    }

    private static double ObterIPI(double ipi)
    {
        double resultado = ipi;
        return resultado;
    }

    private static double CalcularValorTotal(int quantidade, double valorUnitario, double ipi)
    {
        double valorTotal = quantidade * valorUnitario * (1 + (ipi / 100));
        return valorTotal;
    }

    private static void ExibirResumo(int codigo, int quantidade, double valorUnitario, double ipi, double valorTotal)
    {
        Console.WriteLine($"\nResumo dos valores para o Parafuso (Código {codigo}): ");
        Console.WriteLine($"Quantidade de peças: {quantidade} ");
        Console.WriteLine($"Valor unitário (R$): {valorUnitario:F2} ");
        Console.WriteLine($"Porcentagem de IPI (%): {ipi.ToString("F2", CultureInfo.InvariantCulture)} ");
        Console.WriteLine($"Valor total (R$): {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}