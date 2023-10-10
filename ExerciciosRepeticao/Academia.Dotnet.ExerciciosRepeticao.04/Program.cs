internal class Program
{
    /*
    * 4. Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
    * elevado na y sem utilizar a função pow.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Potência *****");

        Console.Write("Digite o valor de x: ");
        double x = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de y: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("\n----- Resultado -----");

        double resultado = CalcularPotencia(x, y);
        Console.Write($"{x} elevado a {y} é igual a {resultado}");

        Console.ReadKey();
    }

    private static double CalcularPotencia(double x, int y)
    {
        double resultado = 1.0;

        for (int i = 1; i <= y; i++)
        {
            resultado *= x;
        }

        return resultado;
    }
}