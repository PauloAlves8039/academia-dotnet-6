internal class Program
{
    /*
     * 13.Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8. 
     * O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Pesuisar os 2, 4 e 8 no Vetor *****");

        int tamanhoDoVetor = 100;
        int[] vetor = new int[tamanhoDoVetor];
        int tamanho = 0;

        Console.WriteLine("Digite números inteiros e positivos (ou -1 para sair):");

        while (tamanho < tamanhoDoVetor)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == -1)
            {
                break;
            }

            if (numero > 0)
            {
                vetor[tamanho] = numero;
                tamanho++;
            }
            else
            {
                Console.WriteLine("Por favor, digite um número inteiro e positivo.");
            }
        }

        int contarValorDois = ContarValores(vetor, tamanho, 2);
        int contarValorQuatro = ContarValores(vetor, tamanho, 4);
        int contarValorOito = ContarValores(vetor, tamanho, 8);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"O número 2 apareceu {contarValorDois} vezes.");
        Console.WriteLine($"O número 4 apareceu {contarValorQuatro} vezes.");
        Console.WriteLine($"O número 8 apareceu {contarValorOito} vezes.");

        Console.ReadKey();
    }

    static int ContarValores(int[] vetor, int tamanho, int numero)
    {
        int contador = 0;

        for (int i = 0; i < tamanho; i++)
        {
            if (vetor[i] == numero)
            {
                contador++;
            }
        }

        return contador;
    }
}