internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
         * O programa deve mostrar os dados do atleta mais novo e mais alto.
        */

        Console.WriteLine("***** Comparar Dados de Atletas *****");

        List<string> listaDeNomes = new List<string>();
        List<int> listaDeIdades = new List<int>();
        List<double> listaDeAlturas = new List<double>();

        Console.WriteLine("Informe os dados do(a) primeiro(a) atleta:");
        Console.Write("Nome: ");
        listaDeNomes.Add(Console.ReadLine());
        Console.Write("Idade: ");
        listaDeIdades.Add(int.Parse(Console.ReadLine()));
        Console.Write("Altura: ");
        listaDeAlturas.Add(double.Parse(Console.ReadLine()));

        Console.WriteLine("Informe os dados do(a) segundo(a) atleta:");
        Console.Write("Nome: ");
        listaDeNomes.Add(Console.ReadLine());
        Console.Write("Idade: ");
        listaDeIdades.Add(int.Parse(Console.ReadLine()));
        Console.Write("Altura: ");
        listaDeAlturas.Add(double.Parse(Console.ReadLine()));

        Console.WriteLine("\n----- Resultado -----");

        string maisVelho = ConferirAtletaMaisVelho(listaDeNomes, listaDeIdades);
        string maisAlto = VerificarAtletaMaisAlto(listaDeNomes, listaDeAlturas);

        Console.WriteLine(maisVelho);
        Console.WriteLine(maisAlto);

        Console.ReadKey();
    }

    private static string ConferirAtletaMaisVelho(List<string> nomes, List<int> idades)
    {
        if (idades.Count < 2)
        {
            return "Não há informações suficientes para analisar os dados!.";
        }

        int indiceAtletaMaisVelho = 0;

        for (int i = 1; i < idades.Count; i++)
        {
            if (idades[i] > idades[indiceAtletaMaisVelho])
            {
                indiceAtletaMaisVelho = i;
            }
        }
        
        return $"{nomes[indiceAtletaMaisVelho]} é o(a) atleta mais velho(a).";
    }

    private static string VerificarAtletaMaisAlto(List<string> nomes, List<double> alturas)
    {
        int indiceAtletaMaisAlto = 0;

        for (int i = 1; i < alturas.Count; i++)
        {
            if (alturas[i] > alturas[indiceAtletaMaisAlto])
            {
                indiceAtletaMaisAlto = i;
            }
        }
        
        return $"{nomes[indiceAtletaMaisAlto]} é o(a) atleta mais alto(a).";
    }

}