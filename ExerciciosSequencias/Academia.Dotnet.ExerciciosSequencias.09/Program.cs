using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
           do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
           Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
           se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
           Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
           da entrada e das duas prestações, de acordo com as regras acima. 
           Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
           conseqüente pagamento dos boletos das duas prestações.
        */

        Console.WriteLine("***** Calcular Prestações *****");

        Console.Write("Informe o valor da mercadoria (R$): ");
        double valorMercadoria = double.Parse(Console.ReadLine());

        double entrada = CalcularEntrada(valorMercadoria);
        double prestacao = CalcularPrestacao(valorMercadoria);

        Console.WriteLine($"\nValor da entrada (R$): {entrada.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor das duas prestações (R$): {prestacao.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    private static double CalcularEntrada(double valorMercadoria)
    {
        return Math.Floor(valorMercadoria);
    }

    private static double CalcularPrestacao(double valorMercadoria)
    {
        double parteDecimal = valorMercadoria - Math.Floor(valorMercadoria);
        double prestacao = Math.Round(parteDecimal * 100, 2);

        if (prestacao < 1)
        {
            prestacao = 1;
        }

        return prestacao / 100;
    }
}