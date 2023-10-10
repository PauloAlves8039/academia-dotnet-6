internal class Program
{
    /*
     * 5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Encontrar Menor Elemento de Vetor *****");

        int tamanhoDoVetor = 10;

        int[] vetor = new int[tamanhoDoVetor];

        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            Console.Write($"Digite o valor para a posição {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out vetor[i]) == false)
            {
                Console.WriteLine("Por favor, insira um valor inteiro válido.");
                i--;
            }
        }

        var resultado = EncontrarMenorElemento(vetor);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"O menor elemento é {resultado.MenorElemento} e está na posição {resultado.PosicaoMenorElemento + 1}.");

        Console.ReadKey();
    }

    private static (int MenorElemento, int PosicaoMenorElemento) EncontrarMenorElemento(int[] vetor)
    {
        int menorElemento = vetor[0];
        int posicaoDoMenorElemento = 0;

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menorElemento)
            {
                menorElemento = vetor[i];
                posicaoDoMenorElemento = i;
            }
        }

        return (menorElemento, posicaoDoMenorElemento);
    }
}