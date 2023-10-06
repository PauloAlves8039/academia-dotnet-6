internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 6. Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações 
         * aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final 
         * (média das notas das avaliações).
        */

        Console.WriteLine("***** Calcular Notas dos Alunos *****");

        Console.Write("Digite o número de alunos na turma: ");
        int numeroDeAlunos = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de avaliações aplicadas: ");
        int quantidadeDeAvaliacoes = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroDeAlunos; i++)
        {
            double media = CalcularMedia(quantidadeDeAvaliacoes, i);
            Console.WriteLine($"A nota final do aluno {i} é: {media:F2}");
        }

        Console.ReadKey();
    }

    static double CalcularMedia(int quantidadeDeAvaliacoes, int alunoNumero)
    {
        double somaNotas = 0;

        for (int j = 1; j <= quantidadeDeAvaliacoes; j++)
        {
            Console.Write($"Digite a nota da avaliação {j} para o aluno {alunoNumero}: ");
            double nota = double.Parse(Console.ReadLine());
            somaNotas += nota;
        }

        return somaNotas / quantidadeDeAvaliacoes;
    }
}