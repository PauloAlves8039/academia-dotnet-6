internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 3. Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
         * x lido utilizando laços de repetição, e mostre na tela.
        */

        Console.Write("Digite um número para calcular a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("\n----- Resultado -----");

        ExibirTabuadaDeSoma(numero);

        Console.ReadKey();
    }

    private static void ExibirTabuadaDeSoma(int numero)
    {
        Console.WriteLine($"Tabuada de {numero} (soma): ");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero + i;
            Console.WriteLine($"{numero} + {i} = {resultado}");
        }
    }
}