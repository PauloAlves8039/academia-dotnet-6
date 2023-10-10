using System.Globalization;

internal class Program
{
    /*
    * 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores 
    * e o valor por hora recebido por cada um deles. 
    * Mostrar na tela qual dos professores tem o maior salário total.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Salário de Professor *****");

        Console.Write("\nDigite a quantidade de horas aula do primeiro professor: ");
        double horasAula1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor por hora do primeiro professor: ");
        double valorPorHora1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade de horas aula do segundo professor: ");
        double horasAula2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor por hora do segundo professor: ");
        double valorPorHora2 = Convert.ToDouble(Console.ReadLine());

        double salarioTotal1 = CalcularSalarioProfessor(horasAula1, valorPorHora1);
        double salarioTotal2 = CalcularSalarioProfessor(horasAula2, valorPorHora2);

        Console.WriteLine("\n----- Descrições -----");

        Console.WriteLine();

        Console.WriteLine($"Salário total do primeiro professor: R${salarioTotal1.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Salário total do segundo professor: R${salarioTotal2.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine();

        ExibirMaiorSalario(salarioTotal1, salarioTotal2);

        Console.ReadKey();
    }

    private static void ExibirMaiorSalario(double primeiroSalario, double segundoSalario) 
    {
        if (primeiroSalario > segundoSalario)
        {
            Console.WriteLine("O primeiro professor tem o maior salário total.");
        }
        else if (segundoSalario > primeiroSalario) 
        {
            Console.WriteLine("O segundo professor tem o maior salário total.");
        }
    }

    private static double CalcularSalarioProfessor(double horasAula, double valorPorHora)
    {
        double resultado = horasAula * valorPorHora;
        return resultado;
    }
}