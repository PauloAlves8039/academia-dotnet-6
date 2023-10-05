using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), 
         * a altura (metros) e o peso (kg) de uma pessoa.
         * O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
         * O cálculo do imc = peso / (altura * altura)
        */

        Console.WriteLine("***** Cálculo de IMC *****");

        Console.WriteLine("Calculadora de IMC");
        Console.Write("Digite seu nome em maiúsculo: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua altura em metros: ");
        int altura = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite seu peso em kg: ");
        int peso = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultadoIMC = CalcularIMC(peso, altura);

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine();

        Console.Write($"O IMC de {nome} é: {resultadoIMC.ToString("F2", CultureInfo.InvariantCulture)}");

        string situacao = ObterSituacaoIMC(resultadoIMC);

        Console.WriteLine();

        Console.WriteLine($"Situação: {situacao}");

        Console.ReadKey();
    }

    private static double CalcularIMC(int peso, int altura)
    {
        double imc = peso / (altura * altura);
        return imc;
    }

    private static string ObterSituacaoIMC(double imc)
    {
        if (imc < 18.00)
        {
            return "Baixo peso";
        }
        else if (imc >= 18.00 && imc <= 25.00)
        {
            return "Peso normal";
        }
        else if (imc >= 25.00 && imc <= 30.00)
        {
            return "Sobrepeso";
        }
        else if (imc >= 30.00 && imc <= 35.00)
        {
            return "Obesidade";
        }
        else
        {
            return "Obesidade grau sério";
        }
    }
}