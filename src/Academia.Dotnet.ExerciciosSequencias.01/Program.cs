internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Média Aritmética *****");

        /*
         * 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
        */

        Console.Write("Informe o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Informe o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        var resultadoExercicio1 = CalcularMediaAritmeticaDoisNumeros(valor1, valor2);

        Console.WriteLine($"A média aritmética entre {valor1} e {valor2} é: {resultadoExercicio1}");

        Console.ReadKey();
    }

    
    private static int CalcularMediaAritmeticaDoisNumeros(int valor1, int valor2) 
    {
        int resultado = (valor1 + valor2) / 2;
        return resultado;
    }

}