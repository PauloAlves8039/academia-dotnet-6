using System.Globalization;

internal class Program
{
    /*
    * 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
    * Área do triangulo = (base * altura) / 2; 
    * Teste se a base ou a altura digitada não foi igual a zero. 
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Área de um Triângulo *****");

        Console.Write("\nDigite o valor da base do triângulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor da altura do triângulo: ");
        double alturaTriangulo = double.Parse(Console.ReadLine());

        double resultadoExercicio1 = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine($"A área do triângulo é: {resultadoExercicio1.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    private static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
    {
        return (baseTriangulo * alturaTriangulo) / 2;
    }
}