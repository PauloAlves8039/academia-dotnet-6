using System.Globalization;

class Program
{
    /*
     * 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
     * Número de pessoas do sexo masculino.
     * Número de pessoas do sexo feminino.
     * Número de pessoas com idade inferior a 30 anos.
     * Número de pessoas com idade superior a 60 anos.
     * Média de idade das mulheres.
    */

    private static void Main()
    {
        Console.WriteLine("***** Especificar Dados de Pessoas *****");
        
        int totalPessoas = 3;
        int countMasculino = 0;
        int countFeminino = 0;
        int countMenos30 = 0;
        int countMais60 = 0;
        int somaIdadeMulheres = 0;

        for (int i = 1; i <= totalPessoas; i++)
        {
            Console.WriteLine($"Pessoa {i}°:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sexo (M/F): ");
            char sexo = Console.ReadLine().ToUpper()[0];

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (sexo == 'M' || sexo == 'm')
            {
                countMasculino++;
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                countFeminino++;
                somaIdadeMulheres += idade;
            }

            ContadoresIdade(idade, ref countMenos30, ref countMais60);
        }

        double mediaIdadeMulheres = CalcularMediaIdadeMulheres(somaIdadeMulheres, countFeminino);

        Console.WriteLine("------ Resultado ------");
        Console.WriteLine($"Número de pessoas do sexo masculino: {countMasculino}");
        Console.WriteLine($"Número de pessoas do sexo feminino: {countFeminino}");
        Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {countMenos30}");
        Console.WriteLine($"Número de pessoas com idade superior a 60 anos: {countMais60}");
        Console.WriteLine($"Média de idade das mulheres: {mediaIdadeMulheres.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    private static void ContadoresIdade(int idade, ref int countMenos30, ref int countMais60)
    {
        if (idade < 30)
        {
            countMenos30++;
        }
        else if (idade > 60)
        {
            countMais60++;
        }
    }

    private static double CalcularMediaIdadeMulheres(int somaIdadeMulheres, int countFeminino)
    {
        return countFeminino > 0 ? (double)somaIdadeMulheres / countFeminino : 0;
    }
}
