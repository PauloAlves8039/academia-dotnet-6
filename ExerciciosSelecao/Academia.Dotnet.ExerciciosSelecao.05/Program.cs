internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Média de Duas Notas *****");

        Console.Write("Informe a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Informe a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        double media = CalcularMedia(nota1, nota2);

        if (media > 7.0)
        {
            Console.Write("Informe a nota do exame: ");
            double notaExame = double.Parse(Console.ReadLine());

            double mediaFinal = CalcularMediaFinal(media, notaExame);

            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
        else
        {
            Console.WriteLine("Aprovado");
        }

        Console.ReadKey();
    }

    private static double CalcularMedia(double nota1, double nota2)
    {
        return (nota1 + nota2) / 2;
    }

    private static double CalcularMediaFinal(double media, double notaExame)
    {
        return (media + notaExame) / 2;
    }
}
