internal class Program
{
    private static int votosJoao = 0;
    private static int votosZeca = 0;
    private static int votosBranco = 0;
    private static int votosNulo = 0;
    private static int totalVotos = 0;

    private static void Main(string[] args)
    {
        /*
         * 5. Modifique o programa em VS anterior para aceitar votos nulos 
         * (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
         * Ao final, informe o nome do candidato vencedor, o número de votos nulos 
         * e o número de pessoas que votaram.
        */

        InstrucoesDaVotacao();

        while (true)
        {
            string voto = Console.ReadLine().ToUpper();

            if (voto == "FIM")
            {
                break;
            }

            totalVotos++;
            ProcessamentoDoVoto(voto);
        }

        ApresentacaoDosResultado();

        Console.ReadKey();
    }

    private static void InstrucoesDaVotacao()
    {
        Console.WriteLine("Digite 'JOAO' para votar em João.");
        Console.WriteLine("Digite 'ZECA' para votar em Zeca.");
        Console.WriteLine("Digite 'BRANCO' para votar em branco.");
        Console.WriteLine("Digite 'NULO' para votar nulo.");
        Console.WriteLine("Digite 'FIM' para encerrar.");
    }

    private static void ProcessamentoDoVoto(string voto)
    {
        switch (voto)
        {
            case "JOAO":
                votosJoao++;
                break;
            case "ZECA":
                votosZeca++;
                break;
            case "BRANCO":
                votosBranco++;
                break;
            case "NULO":
                votosNulo++;
                break;
            default:
                Console.WriteLine("Voto inválido! Tente novamente.");
                break;
        }
    }

    private static void ApresentacaoDosResultado()
    {
        Console.WriteLine("\n----- Resultado -----");
        Console.WriteLine($"Total de votos para JOAO: {votosJoao}");
        Console.WriteLine($"Total de votos para ZECA: {votosZeca}");
        Console.WriteLine($"Total de votos em branco: {votosBranco}");
        Console.WriteLine($"Total de votos nulos: {votosNulo}");
        Console.WriteLine($"Total de pessoas que votaram: {totalVotos}");
    }
}
