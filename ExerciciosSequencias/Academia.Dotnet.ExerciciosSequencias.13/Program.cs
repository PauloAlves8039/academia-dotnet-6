using System.Globalization;

internal class Program
{
    /*
    * 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
    * preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
    * vendidas pelo vendedor, calcule e mostre: o salário do empregado
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Salário de Empregado");

        Console.Write("Digite o valor do salário mínimo: ");
        double salarioMinimo = double.Parse(Console.ReadLine());

        Console.Write("Digite o preço de custo de cada bicicleta: ");
        double precoCustoBicicleta = double.Parse(Console.ReadLine());

        Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
        int numeroBicicletasVendidas = int.Parse(Console.ReadLine());

        double resultadoExercicio13 = CalcularSalarioEmpregado(salarioMinimo, precoCustoBicicleta, numeroBicicletasVendidas);

        Console.WriteLine($"O salário do empregado é: R$ {resultadoExercicio13.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    private static double CalcularSalarioEmpregado(double salarioMinimo, double precoCustoBicicleta, int numeroBicicletasVendidas)
    {
        double salarioEmpregado = 2 * salarioMinimo + (0.15 * precoCustoBicicleta * numeroBicicletasVendidas);
        return salarioEmpregado;
    }
}