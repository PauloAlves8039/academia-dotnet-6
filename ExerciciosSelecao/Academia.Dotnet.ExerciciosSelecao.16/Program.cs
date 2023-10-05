internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. 
         * Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
         * na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. 
         * Caso contrário, mostre uma mensagem indicando que os dois times irão se
         * enfrentar novamente em um novo jogo.
         * ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
         * ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
         * plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
        */

        Console.WriteLine("***** Classificação do Time na Copa do Brasil *****");

        Console.Write("Informe o placar do jogo (time da casa): ");
        int placarCasa = int.Parse(Console.ReadLine());

        Console.Write("Informe o placar do jogo (time de fora): ");
        int placarFora = int.Parse(Console.ReadLine());

        VerificarPlacar(placarCasa, placarFora);

        Console.ReadKey();
    }

    private static void VerificarPlacar(int placarCasa, int placarFora)
    {
        if (placarCasa < placarFora)
        {
            int diferencaGols = placarFora - placarCasa;

            if (diferencaGols > 2)
            {
                Console.WriteLine("O time de fora já se classificou para a próxima fase.");
            }
            else
            {
                Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");
                Console.Write("Informe o placar do segundo jogo (time da casa): ");

                int placarCasa2 = int.Parse(Console.ReadLine());

                Console.Write("Informe o placar do segundo jogo (time de fora): ");

                int placarFora2 = int.Parse(Console.ReadLine());

                if (placarCasa2 + placarFora2 > placarCasa + placarFora)
                {
                    Console.WriteLine("O time de fora passou para a próxima fase.");
                }
                else
                {
                    Console.WriteLine("O time da casa passou para a próxima fase.");
                }
            }
        }
        else
        {
            Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");
            Console.Write("Informe o placar do segundo jogo (time da casa): ");

            int placarCasa2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o placar do segundo jogo (time de fora): ");

            int placarFora2 = int.Parse(Console.ReadLine());

            if (placarCasa2 + placarFora2 > placarCasa + placarFora)
            {
                Console.WriteLine("O time de fora passou para a próxima fase.");
            }
            else
            {
                Console.WriteLine("O time da casa passou para a próxima fase.");
            }
        }
    }
}