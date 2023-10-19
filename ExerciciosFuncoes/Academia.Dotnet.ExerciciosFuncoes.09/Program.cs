internal class Program
{
    /*
     * 9) Escrever um programa com uma função que receba por parâmetro dois números (n1 e n2) 
     * e retorna a soma dos números inteiros que existem entre n1 e n2 (inclusive ambos). Apresente o resultado na main.
     * Desafio: Ler um vetor de inteiros com 10 elementos e passar por parâmetro para uma função que verifica 
     * e retorna o menor elemento do vetor.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Soma Entre Valores *****");

        Console.WriteLine("Digite dois números inteiros: ");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        int resultadoDaSoma = SomaEntreNumeros(n1, n2);

        Console.WriteLine("----- Resultado - Soma Entre Números -----");
        Console.WriteLine($"A soma entre os números {n1} e {n2} é: {resultadoDaSoma}");

        Console.WriteLine("\n***** Informar Menor Elemento de Vetor *****");

        int tamanhoDoVetor = 10;
        int[] vetor = new int[tamanhoDoVetor];

        Console.WriteLine();
       
        LerVetor(vetor, tamanhoDoVetor);

        int menorElemento = EncontrarMenorElemento(vetor);

        Console.WriteLine("----- Resultado - Menor Elemento no Vetor -----");
        Console.WriteLine($"O menor elemento no vetor é: {menorElemento}");

        Console.ReadKey();
    }

    private static void LerVetor(int[] vetor, int tamanhoDoVetor)
    {
        Console.WriteLine("Digite 10 números inteiros: ");

        for (int i = 0; i < tamanhoDoVetor; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    private static int SomaEntreNumeros(int numero1, int numero2)
    {
        int soma = 0;

        for (int i = numero1; i <= numero2; i++)
        {
            soma += i;
        }

        return soma;
    }

    private static int EncontrarMenorElemento(int[] vetor)
    {
        int menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        return menor;
    }
}