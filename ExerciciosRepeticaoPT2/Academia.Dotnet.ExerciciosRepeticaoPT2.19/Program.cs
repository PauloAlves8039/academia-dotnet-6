using System.Globalization;

internal class Program
{
    /*
     * 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
     * coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
     * a) média do salário da população;
     * b) média do número de filhos;
     * c) maior salário;
     * d) percentual de pessoas com salário até R$ 100,00.
     * O final da leitura de dados se dará com a entrada de um salário negativo.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Média de Dados da População *****");

        int pessoasAteCem = 0;
        int contadorDePessoas = 0;
        int somaDosFilhos = 0;
        double somaDosSalarios = 0;
        double maiorSalario = double.MinValue;
        
        Console.WriteLine("Informe o salário da pessoa (digite um valor negativo para encerrar):");

        while (true)
        {
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 0) 
            {
                break;
            }

            contadorDePessoas++;
            somaDosSalarios += salario;

            Console.Write("Número de filhos: ");
            int numFilhos = int.Parse(Console.ReadLine());
            somaDosFilhos += numFilhos;

            if (salario > maiorSalario) 
            {
                maiorSalario = salario;
            }

            if (salario <= 100) 
            {
                pessoasAteCem++;
            }
        }

        if (contadorDePessoas > 0)
        {
            double mediaDosSalarios = CalcularMediaDosSalarios(somaDosSalarios, contadorDePessoas);
            double mediaFilhos = CalcularMediaDosFilhos(somaDosFilhos, contadorDePessoas);
            double percentualAteCem = CalcularPercentualAteCem(pessoasAteCem, contadorDePessoas);

            Console.WriteLine("-------- Resultado --------");
            Console.WriteLine($"a) Média do salário da população: {mediaDosSalarios.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"b) Média do número de filhos: {mediaFilhos.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"c) Maior salário: {maiorSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"d) Percentual de pessoas com salário até R$ 100,00: {percentualAteCem.ToString("F2", CultureInfo.InvariantCulture)}%");
        }
        else
        {
            Console.WriteLine("Nenhum dado foi inserido.");
        }

        Console.ReadKey();
    }

    private static double CalcularMediaDosSalarios(double somaDosSalarios, int contadorDePessoas) 
    {
        double mediaDosSalarios = somaDosSalarios / contadorDePessoas;
        return mediaDosSalarios;
    }

    private static double CalcularMediaDosFilhos(int somaDosFilhos, int contadorDePessoas) 
    {
        double mediaDosFilhos = (double)somaDosFilhos / contadorDePessoas;
        return mediaDosFilhos;
    }

    private static double CalcularPercentualAteCem(int pessoas, int contadorDePessoas) 
    {
        double percentualAteCem = (double)pessoas / contadorDePessoas * 100;
        return percentualAteCem;
    }
}
