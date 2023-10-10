internal class Program
{
    /*
    * 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
    * forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Formatar Data *****");

        Console.Write("Digite a data no formato DDMMAAAA: ");
        string dataDeEntrada = Console.ReadLine();

        Console.WriteLine("---------- Resultado ----------");

        Console.WriteLine();
        FormatarData(dataDeEntrada);

        Console.ReadKey();
    }

    private static void FormatarData(string data)
    {
        if (data.Length != 8)
        {
            Console.WriteLine("Formato de data inválido. Tente inserir 8 dígitos.");
        }
        else
        {
            int dia = int.Parse(data.Substring(0, 2));
            int mes = int.Parse(data.Substring(2, 2));
            int ano = int.Parse(data.Substring(4, 4));

            string formatoDataAAAAMMDD = $"{ano:D4}{mes:D2}{dia:D2}";
            string formatoDataAAMMDD = $"{ano % 100:D2}{mes:D2}{dia:D2}";

            Console.WriteLine($"Data no formato AAAAMMDD: {formatoDataAAAAMMDD}");
            Console.WriteLine($"Data no formato AAMMDD: {formatoDataAAMMDD}");
        }
    }
}