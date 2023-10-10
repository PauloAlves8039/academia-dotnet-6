internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 7.Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares 
         * lidos e após todos os ímpares. Exemplo:
         * a. lê: |7|40|3|9|21|0|63|31|7|22|
         * b. escreve: 	|40|0|22|7|3|9|21|63|31|7|
        */

        int[] numeros = new int[10];
        int[] pares = new int[10];
        int[] impares = new int[10];
        int contadorPares = 0;
        int contadorImpares = 0;

        Console.WriteLine("Digite dez números inteiros:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                pares[contadorPares] = numeros[i];
                contadorPares++;
            }
            else
            {
                impares[contadorImpares] = numeros[i];
                contadorImpares++;
            }
        }

        Console.WriteLine("\nNúmeros pares lidos:");
        for (int i = 0; i < contadorPares; i++)
        {
            Console.Write($"{pares[i]}|");
        }

        Console.WriteLine("\nNúmeros ímpares lidos:");
        for (int i = 0; i < contadorImpares; i++)
        {
            Console.Write($"{impares[i]}|");
        }

        Console.ReadKey();
    }
}