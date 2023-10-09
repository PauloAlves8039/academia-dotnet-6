using System.Globalization;

internal class Program
{
    /*
     * 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
     * ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
     * Considerar nota 7,0 como mínima para aprovação.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Média Ponderada *****");

        Console.WriteLine("Digite as 4 notas do aluno:");

        double somaNotas = 0;

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"Nota {i}: ");
            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double peso;
            switch (i)
            {
                case 1:
                    peso = 2.0;
                    break;
                case 2:
                    peso = 1.0;
                    break;
                case 3:
                    peso = 2.0;
                    break;
                case 4:
                    peso = 4.0;
                    break;
                default:
                    peso = 1.0;
                    break;
            }

            somaNotas += nota * peso;
        }

        double mediaPonderada = CalcularMediaPonderada(somaNotas);

        Console.WriteLine($"Média ponderada: {mediaPonderada.ToString("F1", CultureInfo.InvariantCulture)}");

        if (mediaPonderada >= 7.0)
        {
            Console.WriteLine("Aluno APROVADO!");
        }
        else
        {
            Console.WriteLine("Aluno REPROVADO!");
        }

        Console.ReadKey();
    }

    private static double CalcularMediaPonderada(double somaNotas)
    {
        return somaNotas / 9.0;
    }
}