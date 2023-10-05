internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
         * O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
         * exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
        */

        Console.WriteLine("***** Pesquisar Palavra *****");

        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        Console.Write("Digite uma palavra para pesquisar: ");
        string palavra = Console.ReadLine();

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine();

        PesquisarPalavra(frase, palavra);

        Console.ReadKey();
    }

    private static bool PesquisarPalavra(string frase, string palavra) 
    {
        bool palavraRecebida = frase.Contains(palavra);

        if (palavraRecebida)
        {
            Console.WriteLine($"A palavra '{palavra}' encontra-se na frase '{frase}'");
        }
        else
        {
            Console.WriteLine($"A palavra '{palavra}' não se encontra na frase '{frase}'");
        }

        return palavraRecebida;
    } 
}