internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 5. Modifique o programa em VS anterior para aceitar votos nulos 
         * (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
         * Ao final, informe o nome do candidato vencedor, o número de votos nulos 
         * e o número de pessoas que votaram.
        */

        int votosJoao = 0;
        int votosZeca = 0;
        int votosBranco = 0;
        int votosNulo = 0;

        Console.WriteLine("Digite 'JOAO' para votar em João.");
        Console.WriteLine("Digite 'ZECA' para votar em Zeca.");
        Console.WriteLine("Digite 'BRANCO' para votar em branco.");
        Console.WriteLine("Digite 'NULO' para votar nulo.");
        Console.WriteLine("Digite 'FIM' para encerrar.");

        while (true)
        {
            string voto = Console.ReadLine().ToUpper();

            if (voto == "FIM")
            {
                break;
            }

            ContarVoto(voto, ref votosJoao, ref votosZeca, ref votosBranco, ref votosNulo);
        }

        Console.WriteLine("\n----- Resultado -----");
        Console.WriteLine($"Total de votos para JOAO: {votosJoao}");
        Console.WriteLine($"Total de votos para ZECA: {votosZeca}");
        Console.WriteLine($"Total de votos em branco: {votosBranco}");
        Console.WriteLine($"Total de votos nulos: {votosNulo}");

        Console.ReadKey();
    }

    static void ContarVoto(string voto, ref int votosJoao, ref int votosZeca, ref int votosBranco, ref int votosNulo)
    {
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
        else if (voto == "NULO")
        {
            votosNulo++;
        }
        else
        {
            Console.WriteLine("Voto inválido! Tente novamente.");
        }
    }
}
