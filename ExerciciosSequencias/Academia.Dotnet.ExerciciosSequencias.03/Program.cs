internal class Program
{
    /*
    * 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
        si os valores de duas variáveis A e B.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Troca de Valores *****");

        Console.Write("\nInforme o valor para A: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("\nInforme o valor para B: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nAntes da troca: A = {valor1}, B = {valor2}");

        Console.WriteLine();

        TrocaDeValores(valor1, valor2);

        Console.ReadKey();
    }

    private static int TrocaDeValores(int numero1, int numero2)
    {
        int A = numero1;
        int B = numero2;

        int temp = A;
        A = B;
        B = temp;

        Console.WriteLine($"Depois da troca: A = {A}, B = {B}");

        return A;
    }
}