using System.Globalization;

internal class Program
{
    /*
    * 1) Fazer uma calculadora das 4 operações (soma, subtração, multiplicação e divisão) 
    * Para isso, precisaremos aceitar números com vírgula.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calculadora *****");

        CultureInfo valorDeEntrada = new CultureInfo("pt-BR");
        CultureInfo valorDeSaida = CultureInfo.InvariantCulture;

        Console.WriteLine("Digite dois números:");
        double numero1 = double.Parse(Console.ReadLine(), valorDeEntrada);
        double numero2 = double.Parse(Console.ReadLine(), valorDeEntrada);

        double resultadoDaSoma = Somar(numero1, numero2);
        double resultadoDaSubtracao = Subtracao(numero1, numero2);
        double resultadoDaMultiplicacao = Multiplicacao(numero1, numero2);
        double resultadoDaDivisao = Divisao(numero1, numero2);

        Console.WriteLine("------ Resultados ------");
        Console.WriteLine($"Soma é: {resultadoDaSoma.ToString("F2", valorDeSaida)}");
        Console.WriteLine($"Subtração é: {resultadoDaSubtracao.ToString("F2", valorDeSaida)}");
        Console.WriteLine($"Multiplicação é: {resultadoDaMultiplicacao.ToString("F2", valorDeSaida)}");
        Console.WriteLine($"Divisão é: {resultadoDaDivisao.ToString("F2", valorDeSaida)}");

        Console.ReadKey();
    }

    private static double Somar(double numero1, double numero2) 
    {
        return numero1 + numero2;
    }

    private static double Subtracao(double numero1, double numero2) 
    {
        return numero1 - numero2;
    }

    private static double Multiplicacao(double numero1, double numero2) 
    {
        return numero1 * numero2;
    }

    private static double Divisao(double numero1, double numero2) 
    {
        return numero1 / numero2;
    }
}