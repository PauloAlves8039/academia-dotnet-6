internal class Program
{
    /*
    * 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Média Aritmética Entre 4 Valores *****");

        int[] valores = new int[4];

        Console.Write("\nInforme o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        valores[0] = valor1;

        Console.Write("Informe o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());
        valores[1] = valor2;

        Console.Write("Informe o terceiro valor: ");
        int valor3 = int.Parse(Console.ReadLine());
        valores[2] = valor3;

        Console.Write("Informe o quarto valor: ");
        int valor4 = int.Parse(Console.ReadLine());
        valores[3] = valor4;

        var resultadoExercicio2 = CalcularMediaAritmeticaQuatroNumeros(valores);

        Console.WriteLine($"\nA média aritmética entre [{valor1}, {valor2}, {valor3}, {valor4}] é: {resultadoExercicio2}");

        Console.ReadKey();
    }

    private static int CalcularMediaAritmeticaQuatroNumeros(int[] numeros)
    {
        int soma = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }

        int media = (soma) / 4;

        return media;
    }
}