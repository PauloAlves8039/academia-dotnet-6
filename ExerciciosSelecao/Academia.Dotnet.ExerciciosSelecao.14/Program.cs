internal class Program
{
    /*
    * 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
    * link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
    * do arquivo usando este link (em minutos).
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Calcular tempo de Download *****");

        Console.Write("Digite o tamanho do arquivo em MB: ");
        double tamanhoArquivoMB = double.Parse(Console.ReadLine());

        Console.Write("Digite a velocidade da internet em Mbps: ");
        double velocidadeInternetMbps = double.Parse(Console.ReadLine());

        double tempoDownloadMinutos = CalcularTempoDownload(tamanhoArquivoMB, velocidadeInternetMbps);

        Console.WriteLine("\n----- Resultado -----");

        Console.WriteLine($"O tempo aproximado de download do arquivo é de {tempoDownloadMinutos:F2} minutos.");


        Console.ReadKey();
    }

    private static double CalcularTempoDownload(double tamanhoArquivoMB, double velocidadeInternetMbps)
    {
        double velocidadeEmMBps = velocidadeInternetMbps * 0.125;
        double tempoDownloadMinutos = tamanhoArquivoMB / velocidadeEmMBps / 60;
        return tempoDownloadMinutos;
    }
}