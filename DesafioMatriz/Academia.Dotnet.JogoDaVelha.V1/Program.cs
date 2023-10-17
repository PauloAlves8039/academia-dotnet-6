internal class Program
{
    /*
     * Desenvolva um jogo da velha utilizando matrizes em C#
     * 1) Faça com que cada jogador insira a sua jogada em uma interface amigavel. 
     * 2) Teste se a posição é válida e caso não seja solicite ao jogador repetir a jogada. 
     * 3) Após cada jogada, apresente o tabuleiro com as jogadas representadas por "X" e "O" e faça a verficação se algum jogador venceu.
     * 4) Caso seja empate, apresente o resultado na tela. 
     * 5) Possilibilite que o jogo seja reinicializado sem a necessidade de reiniciar o jogo. 
    */

    private static char[] tabuleiro = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
    private static char jogadorAtual = 'X';
    private static bool jogoEmAndamento = true;

    private static void Main(string[] args)
    {
        Console.WriteLine("##### Bem-vindo(a) ao Jogo da Velha! #####");
        Console.WriteLine("Pressione qualquer tecla para começar.");
        Console.ReadKey();

        int posicao;

        do
        {
            MontagemDoTabuleiro();

            do
            {
                Console.Write($"Jogador {jogadorAtual} - escolha uma posição (1-9): ");
            } while (!int.TryParse(Console.ReadLine(), out posicao) || !ValidarJogada(posicao - 1));

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

        } while (true);

        Console.ReadKey();
    }

    private static void MontagemDoTabuleiro()
    {
        Console.Clear();
        Console.WriteLine($" {tabuleiro[0]} | {tabuleiro[1]} | {tabuleiro[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[3]} | {tabuleiro[4]} | {tabuleiro[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {tabuleiro[6]} | {tabuleiro[7]} | {tabuleiro[8]} ");
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