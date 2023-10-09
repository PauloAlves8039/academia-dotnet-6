internal class Program
{
    /*
     * 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
     * elevada a um expoente qualquer, ou seja, NM.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular Valor da Porência *****");

        Console.Write("Digite a base (N): ");
        double baseN = double.Parse(Console.ReadLine());

        Console.Write("Digite o expoente (M): ");
        int expoenteM = int.Parse(Console.ReadLine());

        double resultado = CalcularPotencia(baseN, expoenteM);

        Console.WriteLine("------ Resultado ------");

        Console.WriteLine($"O resultado de {baseN}^{expoenteM} é igual a {resultado}");

        Console.ReadKey();
    }

    private static double CalcularPotencia(double valorBase, int valorExpoente) 
    {
        double resultadoDaPotencia = 1;

        for (int i = 0; i < valorExpoente; i++)
        {
            resultadoDaPotencia *= valorBase;
        }

        return resultadoDaPotencia;
    }
}