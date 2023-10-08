internal class Program
{
    /*
     * 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
     * o zoológico num determinado dia, imprimindo:
     * Quantas pessoas tem entre 1 e 3 filhos.
     * Quantas pessoas tem entre 4 e 7 filhos.
     * Quantas pessoas tem mais de 8 filhos.
     * Quantas pessoas não tem filhos.
    */

    private static void Main(string[] args)
    {
        int[] quantidadeDeFilhos = new int[30];
        int pessoasCom1a3Filhos = 0;
        int pessoasCom4a7Filhos = 0;
        int pessoasComMaisDe8Filhos = 0;
        int pessoasSemFilhos = 0;

        for (int i = 0; i < 30; i++)
        {
            Console.Write($"Informe a quantidade de filhos da {i + 1}ª pessoa: ");
            if (int.TryParse(Console.ReadLine(), out quantidadeDeFilhos[i]))
            {
                int resultado = VerificarQuantidadeDePessoas(quantidadeDeFilhos[i]);

                switch (resultado)
                {
                    case 1:
                        pessoasCom1a3Filhos++;
                        break;
                    case 2:
                        pessoasCom4a7Filhos++;
                        break;
                    case 3:
                        pessoasComMaisDe8Filhos++;
                        break;
                    case 4:
                        pessoasSemFilhos++;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                i--;
            }
        }

        Console.WriteLine("------- Resultado -------");
        Console.WriteLine($"Pessoas com 1 a 3 filhos: {pessoasCom1a3Filhos}");
        Console.WriteLine($"Pessoas com 4 a 7 filhos: {pessoasCom4a7Filhos}");
        Console.WriteLine($"Pessoas com mais de 8 filhos: {pessoasComMaisDe8Filhos}");
        Console.WriteLine($"Pessoas sem filhos: {pessoasSemFilhos}");

        Console.ReadKey();
    }

    private static int VerificarQuantidadeDePessoas(int quantidade)
    {
        if (quantidade >= 1 && quantidade <= 3)
        {
            return 1;
        }
        else if (quantidade >= 4 && quantidade <= 7)
        {
            return 2;
        }
        else if (quantidade > 8)
        {
            return 3;
        }
        else if (quantidade == 0)
        {
            return 4;
        }

        return 0;
    }
}