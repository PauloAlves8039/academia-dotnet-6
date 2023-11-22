internal class Program
{
    /*
     * Desenvolva um jogo da velha utilizando matrizes em C#
     * 
     * 1) Faça com que cada jogador insira a sua jogada em uma interface amigavel. 
     * 2) Teste se a posição é válida e caso não seja solicite ao jogador repetir a jogada. 
     * 3) Após cada jogada, apresente o tabuleiro com as jogadas representadas por "X" e "O" e faça a verficação se algum jogador venceu.
     * 4) Caso seja empate, apresente o resultado na tela. 
     * 5) Possilibilite que o jogo seja reinicializado sem a necessidade de reiniciar o programa. 
     * 
     * Desafio extra
     * 1) Faça a implementação de um jogo contra o computador. 
     * 2) Faça o possível para evitar que o jogador vença do computador. 
     * 3) Para facilitar, faça com que o computador inicie jogando.
    */

    private static char[] tabuleiro = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
    private static char jogadorAtual = 'X';
    private static bool jogoEmAndamento = true;

    private static void Main(string[] args)
    {
        char escolha = ' ';

        do
        {
            Console.WriteLine("\n##### Bem-vindo(a) ao Jogo da Velha! #####");
            Console.WriteLine("#    1 - Jogar contra outro jogador      #");
            Console.WriteLine("#    2 - Jogar contra o computador       #");
            Console.WriteLine("#    3 - Sair                            #");
            Console.WriteLine("##########################################");
            Console.Write("\nEscolha uma opção (1/2/3): ");
            escolha = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (escolha)
            {
                case '1':
                    PartidaContraOutroJogador();
                    break;
                case '2':
                    PartidaContraComputador();
                    break;
                case '3':
                    Console.WriteLine("\n\nFim do jogo. Obrigado por jogar!");
                    break;
                default:
                    Console.WriteLine("\n\nEscolha uma opção válida (1/2/3).");
                    break;
            }
        }
        while (escolha != '3');
    }

    private static void PartidaContraOutroJogador()
    {
        ReiniciarJogo();

        do
        {
            MontagemDoTabuleiro();

            int posicao;

            do
            {
                Console.Write($"Jogador {jogadorAtual} - escolha uma posição (1-9): ");
            }
            while (!int.TryParse(Console.ReadLine(), out posicao) || !ValidarJogada(posicao - 1));

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
                Console.Write("\n\nDeseja reiniciar o jogo? (S/N): ");
                char resposta = char.ToUpper(Console.ReadKey().KeyChar);
                if (resposta == 'S')
                {
                    ReiniciarJogo();
                }
                else
                {
                    Console.WriteLine("\n\nFim do jogo. Obrigado por jogar!");
                    break;
                }
            }
        } while (jogoEmAndamento);
    }

    private static void PartidaContraComputador()
    {
        bool continuar = true;

        while (continuar)
        {
            ReiniciarJogo();

            while (jogoEmAndamento)
            {
                MontagemDoTabuleiro();

                int posicao = -1;

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
            }
            Console.Write("\n\nDeseja reiniciar o jogo? (S/N): ");
            char resposta = char.ToUpper(Console.ReadKey().KeyChar);
            if (resposta == 'S')
            {
                continuar = true;
            }
            else
            {
                Console.WriteLine("\n\nFim do jogo. Obrigado por jogar!");
                continuar = false;
            }
        }
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

    private static int EscolherJogadaDoComputador()
    {
        int posicaoComputador;
        int posicaoDefesa = 0;
        int posicaoAtaque = 0;
        int posicaoOportunidade = 0;

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
            for (int i = 0; i < tabuleiro.Length; i++)
            {
                if (tabuleiro[i] == ' ')
                {
                    tabuleiro[i] = 'O';

                    if (VerificarVencedor())
                    {
                        return i + 1;
                    }

                    tabuleiro[i] = ' ';
                }
            }

            do
            {
                posicaoComputador = new Random().Next(0, 9);
            }
            while (!ValidarJogada(posicaoComputador));

            return posicaoComputador + 1;
        }
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
        for (int i = 0; i < tabuleiro.Length; i++)
        {
            tabuleiro[i] = ' ';
        }

        jogadorAtual = 'X';
        jogoEmAndamento = true;
        MontagemDoTabuleiro();
    }

    private static void MontagemDoTabuleiro()
    {
        Console.Clear();
        Console.WriteLine($" {tabuleiro[0]} | {tabuleiro[1]} | {tabuleiro[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[3]} | {tabuleiro[4]} | {tabuleiro[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[6]} | {tabuleiro[7]} | {tabuleiro[8]} ");
        Console.WriteLine();
    }
}