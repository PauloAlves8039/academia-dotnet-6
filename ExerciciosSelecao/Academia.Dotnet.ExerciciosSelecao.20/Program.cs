internal class Program
{
    /*
    * 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. 
    * O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
    * plus: você pode gerar o número de forma randomica (função random c#).
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Jogo de Adivinhação do Número *****");

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação do Número Secreto!");
        Console.WriteLine("Você tem 3 chances para adivinhar o número secreto entre 1 e 30.");
        Console.WriteLine();

        int numeroSecreto = GerarNumeroSecreto();
        int tentativas = 3;

        for (int i = 0; i < tentativas; i++)
        {
            Console.Write($"Tentativa {i + 1}: Digite sua suposição: ");
            int suposicao;

            if (int.TryParse(Console.ReadLine(), out suposicao))
            {
                string mensagem = AvaliarSuposicao(suposicao, numeroSecreto);
                Console.WriteLine(mensagem);

                if (mensagem == "Parabéns! Você acertou o número secreto!")
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, insira um número válido.");
                i--;
            }
        }

        Console.WriteLine($"O número secreto era {numeroSecreto} => O jogo acabou!");

        Console.ReadKey();
    }

    private static int GerarNumeroSecreto()
    {
        Random random = new Random();
        return random.Next(1, 30); 
    }

    private static string AvaliarSuposicao(int suposicao, int numeroSecreto)
    {
        if (suposicao == numeroSecreto)
        {
            return "Parabéns! Você acertou o número secreto!";
        }
        else if (suposicao < numeroSecreto)
        {
            return "O número secreto é maior.";
        }
        else
        {
            return "O número secreto é menor.";
        }
    }

}