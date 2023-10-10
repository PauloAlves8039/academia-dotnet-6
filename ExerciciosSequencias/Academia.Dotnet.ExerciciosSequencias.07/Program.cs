using System.Globalization;

internal class Program
{
    /*
    * 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
    o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
    Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Vendas *****");

        Console.WriteLine("Informe os dados do vendedor:");
        Console.Write("Número do Vendedor: ");
        int numeroVendedor = int.Parse(Console.ReadLine());
        Console.Write("Salário fixo (R$): ");
        double salarioFixo = int.Parse(Console.ReadLine());
        Console.Write("Total de vendas (R$): ");
        double totalVendas = double.Parse(Console.ReadLine());
        Console.Write("Percentual de comissão (%): ");
        double percentualComissao = double.Parse(Console.ReadLine());

        ObterNumeroDoVendedor(numeroVendedor);
        ObterSalario(salarioFixo);

        double salarioTotal = CalcularSalarioTotal(salarioFixo, totalVendas, percentualComissao);

        ExibirResultado(numeroVendedor, salarioTotal);


        Console.ReadKey();
    }

    private static int ObterNumeroDoVendedor(int numero)
    {
        int resultado = numero;
        return resultado;
    }

    private static double ObterSalario(double salario)
    {
        double resultado = salario;
        return resultado;
    }

    private static double CalcularSalarioTotal(double salarioFixo, double totalVendas, double percentualComissao)
    {
        return salarioFixo + (totalVendas * (percentualComissao / 100));
    }

    private static void ExibirResultado(int numeroVendedor, double salarioTotal)
    {
        Console.WriteLine($"\nNúmero do vendedor: {numeroVendedor}");
        Console.WriteLine($"Salário total (R$): {salarioTotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}