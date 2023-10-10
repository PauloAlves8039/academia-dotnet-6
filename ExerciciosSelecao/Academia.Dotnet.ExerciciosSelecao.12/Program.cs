using System.Globalization;

internal class Program
{
    /*
    * Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
    * número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
    * R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
    * armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
    * No final do processamento, exibir o salário total e o salário excedente do operário.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Salário de um Operario *****");

        Console.Write("Digite o código do operário: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de horas trabalhadas: ");
        double numeroHoras = double.Parse(Console.ReadLine());

        Console.WriteLine("\n----- Resultado -----");

        double salario = CalcularSalario(numeroHoras);
        double extra = CalcularHorasExtras(numeroHoras);

        Console.WriteLine($"Código do operário: {codigo}");
        Console.WriteLine($"Salário total do operário: R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Salário excedente do operário: R$ {extra.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    private static double CalcularSalario(double horasTrabalhadas)
    {
        double salario = horasTrabalhadas <= 50 ? horasTrabalhadas * 10.0 : 50 * 10.0 + (horasTrabalhadas - 50) * 20.0;
        return salario;
    }

    private static double CalcularHorasExtras(double horasTrabalhadas)
    {
        double extra = horasTrabalhadas > 50 ? (horasTrabalhadas - 50) * 20.0 : 0.0;
        return extra;
    }
}