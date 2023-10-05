internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
         * O programa deve exibir se a hora digitada está ou não válida. 
         * Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
        */

        Console.WriteLine("***** Verificar Hora e Minutos *****");

        Console.Write("Digite a hora (0 a 23): ");
        int hora = int.Parse(Console.ReadLine());

        Console.Write("Digite os minutos (0 a 59): ");
        int minutos = int.Parse(Console.ReadLine());

        Console.WriteLine("\n----- Resultado -----");

        VerificarHoraEMinutos(hora, minutos);

        Console.ReadKey();
    }

    private static void VerificarHoraEMinutos(int hora, int minutos)
    {
        if (hora >= 0 && hora <= 23)
        {
            if (minutos >= 0 && minutos <= 59)
            {
                Console.WriteLine($"A Hora {hora}:{minutos} é válida!");
            }
            else 
            {
                Console.WriteLine($"A Hora {hora}:{minutos} não é válida!");
            }
        }
        else
        {
            Console.WriteLine($"A Hora {hora}:{minutos} não é válida!");
        }
    }
}