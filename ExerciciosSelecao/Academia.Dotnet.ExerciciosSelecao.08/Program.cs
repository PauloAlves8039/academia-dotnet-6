internal class Program
{
    /*
    * 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
    * Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
    * Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
    * E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do  total de vendas.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Total de Vendas *****");

        Console.WriteLine();

        Console.Write("Digite o código do funcionário: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do funcionário: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o salário base do funcionário: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.Write("Digite o total de vendas do funcionário: ");
        double totalVendas = double.Parse(Console.ReadLine());

        double salarioFinal = calcularSalarioFinal(totalVendas, salarioBase);

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine();

        Console.WriteLine("Código do funcionário: {0}", codigo);
        Console.WriteLine("Nome do funcionário: {0}", nome);
        Console.WriteLine("Salário base: {0:C}", salarioBase);
        Console.WriteLine("Total de vendas: {0:C}", totalVendas);
        Console.WriteLine("Salário final: {0:C}", salarioFinal);

        Console.ReadKey();
    }

    private static double calcularSalarioFinal(double totalVendas, double salarioBase)
    {
        double salarioFinal;

        if (totalVendas > 500.00)
        {
            salarioFinal = salarioBase + (totalVendas * 0.05);
        }
        else if (totalVendas > 1000.00)
        {
            salarioFinal = salarioBase + (totalVendas * 0.07);
        }
        else if (totalVendas > 5000.00)
        {
            salarioFinal = salarioBase + (totalVendas * 0.10);
        }
        else
        {
            salarioFinal = salarioBase;
        }

        return salarioFinal;
    }
}