using System.Globalization;

internal class Program
{
    /*
    * 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
    * diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
    * Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
    * Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
    * 
    * Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
    * menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
    * 150, avisá-lo que será necessário adicionar 2 unidades de insulina.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calculando Glicemias *****");

        List<double> listaDeGlicemias = new List<double>();

        Console.WriteLine("Insira os valores de glicemia:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Insira o valor da glicemia {0}: ", i + 1);
            double glicemia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            listaDeGlicemias.Add(glicemia);
        }

        double media = CalcularMediaGlicemias(listaDeGlicemias);

        Console.WriteLine("\n----- Resultado -----");

        ValidarGlicemias(listaDeGlicemias);

        Console.WriteLine("Média dos valores de glicemia: {0}", media.ToString("F2", CultureInfo.InvariantCulture));

        RecomendarInsulina(media);

        Console.ReadKey();
    }

    private static double CalcularMediaGlicemias(List<double> glicemias)
    {
        double soma = 0;

        int tamanho = glicemias.Count;

        for (int i = 0; i < tamanho; i++)
        {
            soma += glicemias[i];
        }

        return soma / tamanho;
    }

    private static void ValidarGlicemias(List<double> glicemias)
    {
        for (int i = 0; i < glicemias.Count; i++)
        {
            double glicemia = glicemias[i];

            if (glicemia < 65)
            {
                Console.WriteLine("Risco de hipoglicemia! Valor: {0}", glicemia);
            }
            else if (glicemia > 250)
            {
                Console.WriteLine("Risco de hiperglicemia! Valor: {0}", glicemia);
            }
        }
    }

    private static void RecomendarInsulina(double media)
    {
        if (media < 80)
        {
            Console.WriteLine("É recomendado diminuir 2 unidades de insulina.");
        }
        else if (media > 150)
        {
            Console.WriteLine("É recomendado adicionar 2 unidades de insulina.");
        }
    }

}