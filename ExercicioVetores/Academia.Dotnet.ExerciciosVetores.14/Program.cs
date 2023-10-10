internal class Program
{
    /*
     * 14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. 
     * Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido. 
     * Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Menu de Opções em Vetor *****");

        int codigo;
        int tamanhoDoVetor = 5;
        int[] vetor = new int[tamanhoDoVetor];
        int tamanho = 0;

        do
        {
            Console.Write("Digite o código (0 para sair, 1 para mostrar na ordem, 2 para mostrar na ordem inversa, 3 para adicionar números): ");
            codigo = int.Parse(Console.ReadLine());

            if (codigo == 0)
            {
                break;
            }
            else if (codigo == 1)
            {
                if (tamanho == 0)
                {
                    Console.WriteLine("O vetor está vazio.");
                }
                else
                {
                    ImprimirVetor(vetor, tamanho);
                }
            }
            else if (codigo == 2)
            {
                if (tamanho == 0)
                {
                    Console.WriteLine("O vetor está vazio.");
                }
                else
                {
                    ImprimirVetorEmOrdemDecrescente(vetor, tamanho);
                }
            }
            else if (codigo == 3)
            {
                if (tamanho < tamanhoDoVetor)
                {
                    for (int i = 0; i < tamanhoDoVetor; i++)
                    {
                        if (tamanho >= tamanhoDoVetor)
                        {
                            Console.WriteLine("O vetor está cheio. Não é possível adicionar mais números.");
                            break;
                        }

                        Console.Write($"Digite o número {i + 1} de {tamanhoDoVetor}: ");
                        int numero = int.Parse(Console.ReadLine());
                        vetor[tamanho] = numero;
                        tamanho++;
                    }
                }
                else
                {
                    Console.WriteLine("O vetor está cheio. Não é possível adicionar mais números.");
                }
            }
            else
            {
                Console.WriteLine("Código inválido. Tente novamente.");
            }
        } while (true);

        Console.WriteLine("Programa encerrado.");

        Console.ReadKey();
    }

    private static void ImprimirVetor(int[] vetor, int tamanho)
    {
        if (tamanho == 0)
        {
            Console.WriteLine("O vetor está vazio.");
        }
        else
        {
            Console.WriteLine("Vetor na ordem em que foi lido:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();
        }
    }

    private static void ImprimirVetorEmOrdemDecrescente(int[] vetor, int tamanho)
    {
        if (tamanho == 0)
        {
            Console.WriteLine("O vetor está vazio.");
        }
        else
        {
            Console.WriteLine("Vetor na ordem inversa:");
            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.Write($"{vetor[i]} ");
            }
            Console.WriteLine();
        }
    }
}
