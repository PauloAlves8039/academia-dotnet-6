using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
         para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
         realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
         notas de menor valor fossem distribuídas em número mínimo possível. 
         Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
         uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
         Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
         de acordo com o critério da “distribuição ótima”.
        */

        Console.WriteLine("***** Distribuição de Notas *****");

        Console.Write("Digite o valor da quantia solicitada: ");
        decimal valorSolicitado = decimal.Parse(Console.ReadLine());

        DistribuirNotas(valorSolicitado);

        Console.ReadKey();
    }

    private static void DistribuirNotas(decimal valor)
    {
        decimal[] notas = { 50.0m, 20.0m, 10.0m, 5.0m, 1.0m };
        int[] quantidadeNotas = new int[notas.Length];

        Console.WriteLine("Distribuição das notas:");

        for (int i = 0; i < notas.Length; i++)
        {
            quantidadeNotas[i] = (int)(valor / notas[i]);
            valor -= quantidadeNotas[i] * notas[i];
            Console.WriteLine($"Notas de R$ {notas[i].ToString("F2", CultureInfo.InvariantCulture)}: {quantidadeNotas[i]}");
        }
    }
}