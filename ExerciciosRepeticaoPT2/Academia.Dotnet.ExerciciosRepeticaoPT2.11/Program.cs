using System.Globalization;

internal class Program
{
    /*
     * 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
     * a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Média dos Alunos *****");

        double nota;
        double notaMaisAlta = double.MinValue;
        double notaMaisBaixa = double.MaxValue;
        double somaNotas = 0;
        int quantidadeAlunos = 0;

        Console.WriteLine("Digite as notas dos alunos (-1 para encerrar): ");

        while (true)
        {
            string entrada = Console.ReadLine();
            if (entrada == "-1")
                break;

            if (double.TryParse(entrada, out nota))
            {
                notaMaisAlta = Math.Max(notaMaisAlta, nota);
                notaMaisBaixa = Math.Min(notaMaisBaixa, nota);

                AdicionarNota(ref somaNotas, ref quantidadeAlunos, nota);
            }
            else
            {
                Console.WriteLine("Nota inválida. Por favor, insira um número válido ou -1 para encerrar.");
            }
        }

        if (quantidadeAlunos > 0)
        {
            double media = CalcularMedia(somaNotas, quantidadeAlunos);

            Console.WriteLine("------ Resultado ------");
            Console.WriteLine("Nota mais alta: " + notaMaisAlta);
            Console.WriteLine("Nota mais baixa: " + notaMaisBaixa);
            Console.WriteLine("Média aritmética: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Quantidade de alunos: " + quantidadeAlunos);
        }
        else
        {
            Console.WriteLine("Nenhuma nota válida foi inserida.");
        }

        Console.ReadKey();
    }

    private static double CalcularMedia(double soma, int quantidade)
    {
        return soma / quantidade;
    }

    private static void AdicionarNota(ref double soma, ref int quantidade, double nota)
    {
        soma += nota;
        quantidade++;
    }
}