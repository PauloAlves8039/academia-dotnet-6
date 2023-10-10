internal class Program
{
    /*
     * 8.Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva 
     * a posição de cada número menor que zero desse vetor. Exemplo:
     * a. lê: |5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
     * b. escreve: |3|5|6|7|9|10|14|. . .
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Obter Número Menor que Zero *****");

        const int tamanhoDoVetor = 30;
        double[] numeros = new double[tamanhoDoVetor];

        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                numeros[i] = numero;
            }
            else
            {
                Console.WriteLine("Número inválido. Digite novamente.");
                i--;
            }
        }

        Console.WriteLine("Posições dos números menores que zero:");

        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            if (numeros[i] < 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.ReadKey();
    }
}