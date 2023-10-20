internal class Program
{
    /*
     * 3.Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela 
     * o índice da posição dos valores correspondentes a números primos.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar Números Primos em Vetores *****");

        int[] vetor = new int[20];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine("Índices das posições com números primos:");

        for (int i = 0; i < vetor.Length; i++)
        {
            if (VerificarNumeroPrimo(vetor[i]))
            {
                Console.WriteLine($"Vetor[{i}] = {vetor[i]} (índice {i})");
            }
        }

        Console.ReadKey();
    }

    private static bool VerificarNumeroPrimo(int numero)
    {
        if (numero <= 1) 
        {
            return false;
        }
        
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) 
            {
                return false;
            }
        }

        return true;
    }
}