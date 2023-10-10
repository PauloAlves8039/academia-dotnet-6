internal class Program
{
    /*
    * 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
    * Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
    * Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
    * Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
    * escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
    * de votos em branco. 
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Resultado de Votação *****");

        int votosJoao = 0;
        int votosZeca = 0;
        int votosBranco = 0;

        Console.WriteLine("Digite 'JOAO' para votar em João.");
        Console.WriteLine("Digite 'ZECA' para votar em Zeca.");
        Console.WriteLine("Digite 'BRANCO' para votar em branco.");
        Console.WriteLine("Digite 'FIM' para encerrar.");

        while (true)
        {
            string voto = Console.ReadLine().ToUpper();

            if (voto == "FIM")
                break;

            if (voto == "JOAO")
            {
                votosJoao++;
            }
            else if (voto == "ZECA")
            {
                votosZeca++;
            }
            else if (voto == "BRANCO")
            {
                votosBranco++;
            }
            else
            {
                Console.WriteLine("Voto inválido. Tente novamente.");
            }
        }

        ApresentacaoDosResultado(votosJoao, votosZeca, votosBranco);


        Console.ReadKey();
    }

    private static void ApresentacaoDosResultado(int votosJoao, int votosZeca, int votosBranco)
    {
        Console.WriteLine("\n----- Resultado -----");
        Console.WriteLine($"Total de votos para JOAO: {votosJoao}");
        Console.WriteLine($"Total de votos para ZECA: {votosZeca}");
        Console.WriteLine($"Total de votos em branco: {votosBranco}");
    }
}
