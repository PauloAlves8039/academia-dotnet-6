internal class Program
{
    /*
    * 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), 
    * e então diga se esses lados podem ou não formar um triangulo. Para que os lados
    * formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. 
    * Caso os lados formem um triangulo, diga se o mesmo é equilátero (todosos lados iguais), 
    * isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Determinar Tipo do Triângulo *****");

        Console.Write("Digite o valor do lado a: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do lado b: ");
        double ladoB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor do lado c: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine();

        if (FormaTriangulo(ladoA, ladoB, ladoC))
        {
            string tipoTriangulo = DeterminarTipoTriangulo(ladoA, ladoB, ladoC);
            Console.WriteLine($"É um triângulo: {tipoTriangulo}");
        }
        else
        {
            Console.WriteLine("Os lados fornecidos não formam um triângulo!");
        }

        Console.ReadKey();
    }

    private static bool FormaTriangulo(double a, double b, double c)
    {
        return (a + b > c && a + c > b && b + c > a);
    }

    private static string DeterminarTipoTriangulo(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "Equilátero";
        }
        else if (a == b || a == c || b == c)
        {
            return "Isósceles";
        }
        else
        {
            return "Escaleno";
        }
    }
}