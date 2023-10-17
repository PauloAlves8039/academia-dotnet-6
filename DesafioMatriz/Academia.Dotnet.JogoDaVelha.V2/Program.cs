internal class Program
{
    /*
     * Parte 1
     * Desenvolva um jogo da velha utilizando matrizes em C#
     * 
     * Parte 2
     * 1) Faça a implementação de um jogo contra o computador. 
     * 2) Faça o possível para evitar que o jogador vença do computador. 
     * 3) Para facilitar, faça com que o computador inicie jogando.
    */

    private static char[] tabuleiro = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
    private static char jogadorAtual = 'O';
    private static bool jogoEmAndamento = true;

    private static void Main(string[] args)
    {
        Console.WriteLine("##### Bem-vindo(a) ao Jogo da Velha! #####");
        Console.WriteLine("Pressione qualquer tecla para começar.");
        Console.ReadKey();

        int posicao = 0;
        jogadorAtual = 'X';

        do
        {
            MontagemDoTabuleiro();

            if (jogadorAtual == 'X')
            {
                posicao = EscolherJogadaDoComputador();
            }
            else if (jogadorAtual == 'O')
            {
                do
                {
                    Console.Write($"Jogador {jogadorAtual} - escolha uma posição (1-9): ");
                } 
                while (!int.TryParse(Console.ReadLine(), out posicao) || !ValidarJogada(posicao - 1));
            }

            tabuleiro[posicao - 1] = jogadorAtual;

            if (VerificarVencedor())
            {
                MontagemDoTabuleiro();
                Console.WriteLine($"Jogador {jogadorAtual} venceu!");
                jogoEmAndamento = false;
            }
            else if (VerificarTabuleiroCompleto())
            {
                MontagemDoTabuleiro();
                Console.WriteLine("Empate!");
                jogoEmAndamento = false;
            }

            if (jogoEmAndamento)
            {
                jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
            }
            else
            {
                Console.Write("Deseja reiniciar o jogo? (S/N): ");
                char resposta = char.ToUpper(Console.ReadKey().KeyChar);
                if (resposta == 'S')
                {
                    ReiniciarJogo();
                }
                else
                {
                    Console.WriteLine("\nFim do jogo. Obrigado por jogar!");
                    break;
                }
            }
        } 
        while (true);
    }

    private static int EscolherJogadaDoComputador()
    {
        int posicaoComputador;

        int posicaoDefesa = 0;

        for (int i = 0; i < tabuleiro.Length; i++)
        {
            if (tabuleiro[i] == ' ')
            {
                tabuleiro[i] = 'X';

                if (VerificarVencedor())
                {
                    posicaoDefesa = i + 1;
                    break;
                }

                tabuleiro[i] = ' ';
            }
        }

        int posicaoAtaque = 0;
        for (int i = 0; i < tabuleiro.Length; i++)
        {
            if (tabuleiro[i] == ' ')
            {
                tabuleiro[i] = 'O';

                if (VerificarVencedor())
                {
                    posicaoAtaque = i + 1;
                    break;
                }

                tabuleiro[i] = ' ';
            }
        }

        int posicaoOportunidade = 0;
        for (int i = 0; i < tabuleiro.Length; i++)
        {
            if (tabuleiro[i] == ' ')
            {
                tabuleiro[i] = 'O';

                if (VerificarVencedor())
                {
                    posicaoOportunidade = i + 1;
                    break;
                }

                tabuleiro[i] = ' ';
            }
        }

        if (posicaoDefesa > 0)
        {
            return posicaoDefesa;
        }
        else if (posicaoAtaque > 0)
        {
            return posicaoAtaque;
        }
        else if (posicaoOportunidade > 0)
        {
            return posicaoOportunidade;
        }
        else
        {
            do
            {
                posicaoComputador = new Random().Next(0, 9);
            }
            while (!ValidarJogada(posicaoComputador));

            return posicaoComputador + 1;
        }
    }

    private static void MontagemDoTabuleiro()
    {
        Console.Clear();
        Console.WriteLine($" {tabuleiro[0]} | {tabuleiro[1]} | {tabuleiro[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[3]} | {tabuleiro[4]} | {tabuleiro[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[6]} | {tabuleiro[7]} | {tabuleiro[8]} ");
        Console.WriteLine("\nJogador X - Computador.");
        Console.WriteLine("Jogador O - Usuário.\n");
    }

    private static bool ValidarJogada(int posicao)
    {
        return posicao >= 0 && posicao < 9 && tabuleiro[posicao] != 'X' && tabuleiro[posicao] != 'O';
    }

    private static bool VerificarVencedor()
    {
        bool linha1 = tabuleiro[0] == jogadorAtual && tabuleiro[4] == jogadorAtual && tabuleiro[8] == jogadorAtual;
        bool linha2 = tabuleiro[2] == jogadorAtual && tabuleiro[4] == jogadorAtual && tabuleiro[6] == jogadorAtual;

        if (linha1 || linha2)
        {
            return true;
        }

        for (int i = 0; i < 3; i++)
        {
            bool linhaHorizontal = tabuleiro[i] == jogadorAtual && tabuleiro[i + 3] == jogadorAtual && tabuleiro[i + 6] == jogadorAtual;
            bool linhaVertical = tabuleiro[i * 3] == jogadorAtual && tabuleiro[i * 3 + 1] == jogadorAtual && tabuleiro[i * 3 + 2] == jogadorAtual;

            if (linhaHorizontal || linhaVertical)
            {
                return true;
            }
        }

        return false;
    }

    private static bool VerificarTabuleiroCompleto()
    {
        for (int i = 0; i < tabuleiro.Length; i++)
        {
            if (tabuleiro[i] != 'X' && tabuleiro[i] != 'O')
            {
                return false;
            }
        }

        return true;
    }

    private static void ReiniciarJogo()
    {
        tabuleiro = new char[] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        jogadorAtual = 'X';
        jogoEmAndamento = true;
    }
}