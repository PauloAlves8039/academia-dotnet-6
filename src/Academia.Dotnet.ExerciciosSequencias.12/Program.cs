using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
         * marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
         * dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.
         * 
         * Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia
         * Média do consumo = Total quilometragem/ quantidade de combustível gasto
         * Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
        */

        Console.WriteLine("***** Calculo de Rendimento *****");

        double precoCombustivel = 6.90;

        Console.Write("Digite a marcação do odômetro no início do dia (em Km): ");
        double odometroInicio = double.Parse(Console.ReadLine());

        Console.Write("Digite a marcação do odômetro no final do dia (em Km): ");
        double odometroFinal = double.Parse(Console.ReadLine());

        Console.Write("Digite o número de litros de combustível gasto: ");
        double litrosCombustivel = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor total (R$) recebido dos passageiros: ");
        double valorTotalRecebido = double.Parse(Console.ReadLine());

        double totalQuilometragem = CalcularTotalQuilometragem(odometroInicio, odometroFinal);
        double mediaConsumo = CalcularMediaConsumo(totalQuilometragem, litrosCombustivel);
        double lucroDia = CalcularLucroDia(valorTotalRecebido, litrosCombustivel, precoCombustivel);

        Console.WriteLine($"Média do consumo: {mediaConsumo.ToString("F2", CultureInfo.InvariantCulture)} Km/l");
        Console.WriteLine($"Lucro líquido do dia: R${lucroDia.ToString("F2", CultureInfo.InvariantCulture)}");

        Console.ReadKey();
    }

    private static double CalcularTotalQuilometragem(double inicio, double final)
    {
        return final - inicio;
    }

    private static double CalcularMediaConsumo(double totalQuilometragem, double litrosCombustivel)
    {
        return totalQuilometragem / litrosCombustivel;
    }

    private static double CalcularLucroDia(double valorTotalRecebido, double litrosCombustivel, double precoCombustivel)
    {
        return valorTotalRecebido - (litrosCombustivel * precoCombustivel);
    }
}